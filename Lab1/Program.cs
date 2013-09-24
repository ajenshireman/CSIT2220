
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CSIT2220_Lab1
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
            Application.Run(new InventoryUI());
            //Application.Run(new Form1());
        }
    }
}
