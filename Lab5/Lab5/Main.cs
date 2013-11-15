using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Main : Form
    {
        public Main ()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            pnlDiceImg.BackColor = Color.Transparent;
        }

        private void play ()
        {
            Game game = new Game( this );
            this.Hide();
            game.Show();
        }

        private void btnPlay_Click ( object sender, EventArgs e )
        {
            play();
        }
    }
}
