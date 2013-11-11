using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSIT2220_Lab4
{
    public partial class SplashForm : Form
    {
        public SplashForm ()
        {
            InitializeComponent();
            label1.Text = "CSIT 2220 Lab 4";
            timer1.Start();
        }

        private void timer1_Tick ( object sender, EventArgs e )
        {
            this.Close();
        }
    }
}
