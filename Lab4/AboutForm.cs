﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSIT2220_Lab4
{
    public partial class AboutForm : Form
    {
        public AboutForm ()
        {
            InitializeComponent();
            string msg = "CSIT 2220 Lab 4\n" + 
                         "Author: Ajen Shireman\n" +
                         "v1.0 2013-10-07";
            lblAbout.Text = msg;
        }

        private void btnOK_Click ( object sender, EventArgs e )
        {
            this.Close();
        }
    }
}
