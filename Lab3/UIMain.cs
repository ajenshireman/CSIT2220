/**
 * DailySummary.cs
 * Author: Ajen Shireman
 * Course: CSIT 22220
 * Instructor: Mehdi Negahban
 * 
 * Lab 3
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSIT2220_Lab3
{
    public partial class uiMain : Form
    {
        /* Variable Declarations */
        Day currentDay;
        Order currentOrder;
        Drink curentDrink;
        /* End Variable Declarations */

        public uiMain()
        {
            InitializeComponent();
        }

        #region EventHandlers
        /* Menu */
        // File
        private void summaryToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            generateDailySummary();
        }

        private void exitToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            this.Close();
        }

        // Edit
        private void addToOrderToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            addDrink();
        }

        private void clearDrinkToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            clearDrink();
        }

        private void submitOrderToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            submitOrder();
        }

        private void clearOrderToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            clearOrder();
        }

        // View
        private void fontToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            changeFontFace();
        }

        private void colorToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            changeFontColor();
        }

        // Help
        /* End menu */

        /* Buttons */
        // Drink
        private void btnDrinkAdd_Click ( object sender, EventArgs e )
        {

        }

        private void btnDrinkClear_Click ( object sender, EventArgs e )
        {

        }

        // Order
        private void btnOrderSubmit_Click ( object sender, EventArgs e )
        {

        }

        private void btnOrderClear_Click ( object sender, EventArgs e )
        {

        }
        /* End Buttons */

        /* Drink Selection */
        // Drink Type
        private void rbtType_CheckedChanged ( object sender, EventArgs e )
        {

        }

        // Drink Size
        private void rbtSize_CheckedChanged ( object sender, EventArgs e )
        {

        }
        /* End drink selection */
        #endregion

        private void generateDailySummary ()
        {

        }

        private void addDrink ()
        {

        }

        private void clearDrink ()
        {

        }

        private void submitOrder ()
        {

        }

        private void clearOrder ()
        {

        }

        private void changeFontColor ()
        {
            colorDialog1.Color = this.ForeColor;
            colorDialog1.ShowDialog();
            this.ForeColor = colorDialog1.Color;
        }

        private void changeFontFace ()
        {
            fontDialog1.Font = this.Font;
            fontDialog1.ShowDialog();
            this.Font = fontDialog1.Font;
        }

        
        
    }
}
