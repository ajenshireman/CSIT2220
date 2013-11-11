using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CSIT2220_Lab4
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main ()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SplashForm splash = new SplashForm();
            splash.ShowDialog();
            Application.Run(new UIMain());
        }
    }
}
