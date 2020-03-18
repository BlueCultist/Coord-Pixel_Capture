using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Coord_Pixel_Grabber
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CoordPixelGrabber());
        }
    }
}
