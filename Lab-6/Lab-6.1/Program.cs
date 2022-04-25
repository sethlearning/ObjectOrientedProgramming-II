using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6
{
    enum FileType
    {
        jpeg,
        bmp
    }
    enum ImagingMode
    {
        startup,
        pictureBoxImage,
        pictureBoxGraphic1,
        chartGraphic1,
        chartGraphic2
    }
    internal static class Program
    {


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
