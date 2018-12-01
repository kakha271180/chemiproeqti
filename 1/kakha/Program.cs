using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLLFILE;
using System.IO;

namespace kakha
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
            Application.Run(new Form1());

            chacerisclasi.monacemischacera = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "database.db");
        }
    }
}
