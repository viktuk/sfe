using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ViKTUK_SFE
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string path;
            try
            {
                path = args[0];
            }
            catch {
                path = "";
            }
            Application.Run(new Form1(path));
        }
    }
}
