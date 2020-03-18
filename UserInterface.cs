using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using System.Threading.Tasks;
using System.Threading;
using System.Data;
using System.IO;
using System.Drawing.Imaging;
using System.Text;

// To do : 

// When exporting : setting to ask if still export keyless value for people who wants rgb only

namespace Coord_Pixel_Grabber
{
    public partial class CoordPixelGrabber : Form
    {
        [DllImport("user32.dll")]
        static extern IntPtr GetDC(HandleRef hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]

        static extern bool GetCursorPos(out POINT lpPoint);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        static extern bool ScreenToClient(IntPtr hWnd, ref POINT lpPoint);

        [DllImport("gdi32.dll")]
        private static extern int BitBlt(IntPtr srchDc, int srcX, int srcY, int srcW, int srcH,
                         IntPtr desthDc, int destX, int destY, int op);

        [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int GetAsyncKeyState(int vKey);

        [DllImport("user32.dll", SetLastError = false)]
        static extern IntPtr GetDesktopWindow();

        public struct POINT
        {
            public int X;
            public int Y;

            public POINT(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public static implicit operator System.Drawing.Point(POINT p)
            {
                return new System.Drawing.Point(p.X, p.Y);
            }

            public static implicit operator POINT(System.Drawing.Point p)
            {
                return new POINT(p.X, p.Y);
            }
        }

        IntPtr desktopHwnd = GetDesktopWindow();
        IntPtr hWnd = IntPtr.Zero;
        bool loop = false;
        DataTable dataTable = new DataTable();
        int dtIndex = 0;
        Thread display;
        Thread capture;
        delegate void SetTextCallback(Label lbl, string text);
        delegate void SetBackColorCallBack(PictureBox pb, Color color);
        delegate void SetDataViewGridCallBack();

        public CoordPixelGrabber()
        {
            InitializeComponent();

            for (int i = 0; i < 3; i++)
                dataTable.Columns.Add();

            for (int i = 0; i < 10; i++)
                dataTable.Rows.Add();

            dataGridView.DataSource = dataTable;

            dataGridView.Columns[0].HeaderText = "Coord";
            dataGridView.Columns[0].Width = 60;
            dataGridView.Columns[0].ReadOnly = true;
            dataGridView.Columns[0].Resizable = DataGridViewTriState.False;
            dataGridView.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView.Columns[0].DefaultCellStyle.BackColor = Color.Gray;
            dataGridView.Columns[0].DefaultCellStyle.ForeColor = Color.Black;

            dataGridView.Columns[1].HeaderText = "RGB";
            dataGridView.Columns[1].Width = 70;
            dataGridView.Columns[1].ReadOnly = true;
            dataGridView.Columns[1].Resizable = DataGridViewTriState.False;
            dataGridView.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView.Columns[1].DefaultCellStyle.BackColor = Color.DarkGray;
            dataGridView.Columns[1].DefaultCellStyle.ForeColor = Color.Black;

            dataGridView.Columns[2].HeaderText = "Key";
            dataGridView.Columns[2].ReadOnly = false;
            dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[2].Resizable = DataGridViewTriState.False;
            dataGridView.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView.Columns[2].DefaultCellStyle.BackColor = Color.Gray;
            dataGridView.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
        }

        public Color GetPixel(IntPtr hwnd, int x, int y)
        {
            using (Bitmap screenPixel = new Bitmap(1, 1))
            {
                using (Graphics gdest = Graphics.FromImage(screenPixel))
                {
                    using (Graphics gsrc = Graphics.FromHwnd(hwnd))
                    {
                        IntPtr hsrcdc = gsrc.GetHdc();
                        IntPtr hdc = gdest.GetHdc();
                        BitBlt(hdc, 0, 0, 1, 1, hsrcdc, x, y, (int)CopyPixelOperation.SourceCopy);
                        gdest.ReleaseHdc();
                        gsrc.ReleaseHdc();
                    }
                }
                return screenPixel.GetPixel(0, 0);
            }
        }

        public Color GetColorAt(int x, int y)
        {
            Bitmap screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);

            using (Graphics gdest = Graphics.FromImage(screenPixel))
            {
                using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero))
                {
                    IntPtr hSrcDC = gsrc.GetHdc();
                    IntPtr hDC = gdest.GetHdc();
                    int retval = BitBlt(hDC, 0, 0, 1, 1, hSrcDC, x, y, (int)CopyPixelOperation.SourceCopy);
                    gdest.ReleaseHdc();
                    gsrc.ReleaseHdc();
                }
            }

            return screenPixel.GetPixel(0, 0);
        }

        private void Btn_search_Click(object sender, System.EventArgs e)
        {
            hWnd = FindWindow(null, txt_windowTitle.Text);

            if (hWnd != IntPtr.Zero)
            {
                lbl_statusResult.ForeColor = Color.Yellow;
                lbl_statusResult.Text = "HANDLE FOUND";

                lbl_screenX.Visible = true;
                lbl_screenY.Visible = true;
                lbl_windowX.Visible = true;
                lbl_windowY.Visible = true;
                lbl_rgbR.Visible = true;
                lbl_rgbG.Visible = true;
                lbl_rgbB.Visible = true;
                pb_pixelColor.Visible = true;

                btn_open.Enabled = false;
                loop = true;

                display = new Thread(DisplayInfo);
                display.Start();

                capture = new Thread(GetKeyState);
                capture.Start();
            }
        }

        private void DisplayInfo()
        {
            while (loop)
            {
                POINT p;

                // Screen Coord
                if (GetCursorPos(out p))
                {
                    SetText(lbl_screenX, p.X.ToString());
                    SetText(lbl_screenY, p.Y.ToString());
                }

                // Pixel Color
                Color c = GetPixel(desktopHwnd, p.X, p.Y);
                //Color c = GetColorAt(p.X, p.Y);
                SetText(lbl_rgbR, c.R.ToString());
                SetText(lbl_rgbG, c.G.ToString());
                SetText(lbl_rgbB, c.B.ToString());
                SetBackColor(pb_pixelColor, c);

                // Window Coord
                if (ScreenToClient(hWnd, ref p))
                {
                    SetText(lbl_windowX, p.X.ToString());
                    SetText(lbl_windowY, p.Y.ToString());
                }

                Thread.Sleep(100);
            }
        }

        private void ResetUI()
        {
            lbl_statusResult.Text = "NO HANDLE";
            lbl_statusResult.ForeColor = Color.Red;

            lbl_screenX.Text = "0";
            lbl_screenY.Text = "0";

            lbl_windowX.Text = "0";
            lbl_windowY.Text = "0";

            lbl_rgbR.Text = "0";
            lbl_rgbG.Text = "0";
            lbl_rgbB.Text = "0";

            pb_pixelColor.BackColor = Color.Black;
        }

        private void GetKeyState()
        {
            while (loop)
            {
                if (GetAsyncKeyState(0xBB) != 0) // +
                    SetDataViewGrid();

                Thread.Sleep(200);
            }
        }

        private void SetDataViewGrid()
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (dataGridView.InvokeRequired)
            {
                SetDataViewGridCallBack d = new SetDataViewGridCallBack(SetDataViewGrid);
                this.Invoke(d);
            }
            else
            {
                // Set Coord
                dataTable.Rows[dtIndex][0] = String.Format("{0},{1}", lbl_windowX.Text, lbl_windowY.Text);

                // Set RGB
                dataTable.Rows[dtIndex][1] = String.Format("{0},{1},{2}", lbl_rgbR.Text, lbl_rgbG.Text, lbl_rgbB.Text);

                // Increase index
                dtIndex++;

                // Add new row if needed
                if (dtIndex == dataTable.Rows.Count)
                {
                    dataTable.Rows.Add();
                    dataGridView.FirstDisplayedScrollingRowIndex = dataGridView.RowCount - 1; // Might cause issue
                }

                dataGridView.CurrentCell = dataGridView[0, dtIndex];
            }
        }

        private void SetText(Label lbl, string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (lbl.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { lbl, text });
            }
            else
            {
                lbl.Text = text;
            }
        }

        private void SetBackColor(PictureBox pb, Color color)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (pb.InvokeRequired)
            {
                SetBackColorCallBack d = new SetBackColorCallBack(SetBackColor);
                this.Invoke(d, new object[] { pb, color });
            }
            else
            {
                pb.BackColor = color;
            }
        }

        private void CoordPixelGrabber_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (display != null && display.IsAlive)
                display.Abort();

            if (capture != null && capture.IsAlive)
                capture.Abort();
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            for (int i = dataTable.Rows.Count - 1; i >= 10; i--)
            {
                dataTable.Rows.Remove(dataTable.Rows[i]);
            }

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataTable.Rows[i][0] = String.Empty;
                dataTable.Rows[i][1] = string.Empty;
                dataTable.Rows[i][2] = string.Empty;
            }

            dtIndex = 0;
            dataGridView.CurrentCell = dataGridView[0, dtIndex];
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            // Used to notice user if a key is missing
            bool warning = false;
            // Displays a SaveFileDialog so the user can save the Image  
            // assigned to Button2.  
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text File | *.txt";
            saveFileDialog1.Title = "Save a text file";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(Path.GetFullPath(saveFileDialog1.FileName)))
                {
                    foreach (DataRow dtRow in dataTable.Rows)
                    {
                        if (dtRow.ItemArray[0].ToString() != "" && dtRow.ItemArray[1].ToString() != "" && dtRow.ItemArray[2].ToString() != "")
                            file.WriteLine("<add key=\"{0}\" value=\"{1},{2}\"/>", dtRow[2], dtRow[0], dtRow[1]);
                        else if (dtRow.ItemArray[0].ToString() != "" || dtRow.ItemArray[1].ToString() != "" || dtRow.ItemArray[2].ToString() != "")
                            warning = true;
                    }
                }

                if (warning)
                    MessageBox.Show("Some row were skipped due to a missing key.", "Missing Key", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.SelectedCells.Count > 0)
            {
                dtIndex = dataGridView.SelectedCells[0].RowIndex;
            }
        }

        private void LoadKeyFromFile(string file)
        {
            Btn_clear_Click(null, null); ; // Clear all cell and delete additional row

            try
            {
                string[] lines = File.ReadAllLines(file, Encoding.UTF8);
                int index = 0;

                foreach (string line in lines)
                {
                    if(index < dataTable.Rows.Count)
                    {
                        dataTable.Rows[index][2] = line;
                        index++;
                    }
                    else
                        dataTable.Rows.Add("", "", line);
                }
            }
            catch (Exception e)
            {
                Btn_clear_Click(null, null); ; // Clear all cell and delete additional row
                MessageBox.Show(e.ToString());
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (hWnd != IntPtr.Zero)
            {
                hWnd = IntPtr.Zero;
                loop = false;

                if (display != null && display.IsAlive)
                    display.Abort();

                if (capture != null && capture.IsAlive)
                    capture.Abort();

                ResetUI();

                btn_open.Enabled = true;
            }
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    LoadKeyFromFile(openFileDialog.FileName);
                }
            }
        }
    }
}