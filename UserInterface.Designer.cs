namespace Coord_Pixel_Grabber
{
    partial class CoordPixelGrabber
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoordPixelGrabber));
            this.txt_windowTitle = new System.Windows.Forms.TextBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_statusResult = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_windowY = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_windowX = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_screenY = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_screenX = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pb_pixelColor = new System.Windows.Forms.PictureBox();
            this.lbl_rgbB = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_rgbG = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_rgbR = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_import = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pixelColor)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_windowTitle
            // 
            this.txt_windowTitle.Location = new System.Drawing.Point(6, 19);
            this.txt_windowTitle.Name = "txt_windowTitle";
            this.txt_windowTitle.Size = new System.Drawing.Size(139, 20);
            this.txt_windowTitle.TabIndex = 0;
            this.txt_windowTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_open
            // 
            this.btn_open.ForeColor = System.Drawing.Color.Black;
            this.btn_open.Location = new System.Drawing.Point(151, 16);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(51, 20);
            this.btn_open.TabIndex = 1;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.Btn_search_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(6, 42);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(43, 13);
            this.lbl_status.TabIndex = 2;
            this.lbl_status.Text = "Status :";
            // 
            // lbl_statusResult
            // 
            this.lbl_statusResult.AutoSize = true;
            this.lbl_statusResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_statusResult.ForeColor = System.Drawing.Color.Red;
            this.lbl_statusResult.Location = new System.Drawing.Point(45, 42);
            this.lbl_statusResult.Name = "lbl_statusResult";
            this.lbl_statusResult.Size = new System.Drawing.Size(67, 13);
            this.lbl_statusResult.TabIndex = 3;
            this.lbl_statusResult.Text = "NO HANDLE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_close);
            this.groupBox1.Controls.Add(this.txt_windowTitle);
            this.groupBox1.Controls.Add(this.lbl_statusResult);
            this.groupBox1.Controls.Add(this.btn_open);
            this.groupBox1.Controls.Add(this.lbl_status);
            this.groupBox1.ForeColor = System.Drawing.Color.Lime;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 65);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Handle";
            // 
            // btn_close
            // 
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Location = new System.Drawing.Point(151, 38);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(51, 20);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.ForeColor = System.Drawing.Color.Lime;
            this.groupBox2.Location = new System.Drawing.Point(12, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 172);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Coord";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_windowY);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.lbl_windowX);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.ForeColor = System.Drawing.Color.Lime;
            this.groupBox4.Location = new System.Drawing.Point(6, 90);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(196, 65);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Window";
            // 
            // lbl_windowY
            // 
            this.lbl_windowY.AutoSize = true;
            this.lbl_windowY.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_windowY.Location = new System.Drawing.Point(145, 29);
            this.lbl_windowY.Name = "lbl_windowY";
            this.lbl_windowY.Size = new System.Drawing.Size(13, 13);
            this.lbl_windowY.TabIndex = 3;
            this.lbl_windowY.Text = "0";
            this.lbl_windowY.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(119, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Y :";
            // 
            // lbl_windowX
            // 
            this.lbl_windowX.AutoSize = true;
            this.lbl_windowX.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_windowX.Location = new System.Drawing.Point(65, 29);
            this.lbl_windowX.Name = "lbl_windowX";
            this.lbl_windowX.Size = new System.Drawing.Size(13, 13);
            this.lbl_windowX.TabIndex = 1;
            this.lbl_windowX.Text = "0";
            this.lbl_windowX.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "X :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_screenY);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lbl_screenX);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.ForeColor = System.Drawing.Color.Lime;
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(196, 65);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Screen";
            // 
            // lbl_screenY
            // 
            this.lbl_screenY.AutoSize = true;
            this.lbl_screenY.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_screenY.Location = new System.Drawing.Point(145, 29);
            this.lbl_screenY.Name = "lbl_screenY";
            this.lbl_screenY.Size = new System.Drawing.Size(13, 13);
            this.lbl_screenY.TabIndex = 3;
            this.lbl_screenY.Text = "0";
            this.lbl_screenY.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Y :";
            // 
            // lbl_screenX
            // 
            this.lbl_screenX.AutoSize = true;
            this.lbl_screenX.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_screenX.Location = new System.Drawing.Point(65, 29);
            this.lbl_screenX.Name = "lbl_screenX";
            this.lbl_screenX.Size = new System.Drawing.Size(13, 13);
            this.lbl_screenX.TabIndex = 1;
            this.lbl_screenX.Text = "0";
            this.lbl_screenX.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "X :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pb_pixelColor);
            this.groupBox5.Controls.Add(this.lbl_rgbB);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.lbl_rgbG);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.lbl_rgbR);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.ForeColor = System.Drawing.Color.Lime;
            this.groupBox5.Location = new System.Drawing.Point(12, 261);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(209, 65);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "RGB";
            // 
            // pb_pixelColor
            // 
            this.pb_pixelColor.BackColor = System.Drawing.Color.Black;
            this.pb_pixelColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_pixelColor.Location = new System.Drawing.Point(172, 19);
            this.pb_pixelColor.Name = "pb_pixelColor";
            this.pb_pixelColor.Size = new System.Drawing.Size(30, 33);
            this.pb_pixelColor.TabIndex = 6;
            this.pb_pixelColor.TabStop = false;
            this.pb_pixelColor.Visible = false;
            // 
            // lbl_rgbB
            // 
            this.lbl_rgbB.AutoSize = true;
            this.lbl_rgbB.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_rgbB.Location = new System.Drawing.Point(144, 29);
            this.lbl_rgbB.Name = "lbl_rgbB";
            this.lbl_rgbB.Size = new System.Drawing.Size(13, 13);
            this.lbl_rgbB.TabIndex = 5;
            this.lbl_rgbB.Text = "0";
            this.lbl_rgbB.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(125, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "B :";
            // 
            // lbl_rgbG
            // 
            this.lbl_rgbG.AutoSize = true;
            this.lbl_rgbG.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_rgbG.Location = new System.Drawing.Point(90, 29);
            this.lbl_rgbG.Name = "lbl_rgbG";
            this.lbl_rgbG.Size = new System.Drawing.Size(13, 13);
            this.lbl_rgbG.TabIndex = 3;
            this.lbl_rgbG.Text = "0";
            this.lbl_rgbG.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(71, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "G :";
            // 
            // lbl_rgbR
            // 
            this.lbl_rgbR.AutoSize = true;
            this.lbl_rgbR.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_rgbR.Location = new System.Drawing.Point(36, 29);
            this.lbl_rgbR.Name = "lbl_rgbR";
            this.lbl_rgbR.Size = new System.Drawing.Size(13, 13);
            this.lbl_rgbR.TabIndex = 1;
            this.lbl_rgbR.Text = "0";
            this.lbl_rgbR.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "R :";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btn_import);
            this.groupBox6.Controls.Add(this.panel1);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.btn_clear);
            this.groupBox6.Controls.Add(this.btn_save);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.ForeColor = System.Drawing.Color.Lime;
            this.groupBox6.Location = new System.Drawing.Point(227, 13);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(346, 313);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Capture";
            // 
            // btn_import
            // 
            this.btn_import.ForeColor = System.Drawing.Color.Black;
            this.btn_import.Location = new System.Drawing.Point(6, 284);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(47, 23);
            this.btn_import.TabIndex = 8;
            this.btn_import.Text = "Import";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Location = new System.Drawing.Point(6, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 260);
            this.panel1.TabIndex = 7;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.GridColor = System.Drawing.Color.White;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(334, 260);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(234, 284);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 289);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "for capture";
            // 
            // btn_clear
            // 
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.Location = new System.Drawing.Point(112, 284);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(47, 23);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Reset";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // btn_save
            // 
            this.btn_save.ForeColor = System.Drawing.Color.Black;
            this.btn_save.Location = new System.Drawing.Point(59, 284);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(47, 23);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Export";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 289);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Press";
            // 
            // CoordPixelGrabber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(584, 336);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CoordPixelGrabber";
            this.Text = "Coord & Pixel Grabber";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CoordPixelGrabber_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pixelColor)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_windowTitle;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_statusResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbl_windowY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_windowX;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_screenY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_screenX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pb_pixelColor;
        private System.Windows.Forms.Label lbl_rgbB;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_rgbG;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_rgbR;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_import;
    }
}

