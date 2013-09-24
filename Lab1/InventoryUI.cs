/*
 * InventoryUI.cs
 * Author: Ajen Shireman
 * CSIT 2220 Lab 1
 * 
 * 
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

namespace CSIT2220_Lab1
{
    public partial class InventoryUI : Form
    {
        /* Variable Declarations */
        private decimal invStart;    // Starting Inventory Value
        private decimal invEnd;      // Ending Inventory Value
        private decimal invSold;     // Value of Goods Sold
        private decimal invAvg;      // Average Inventory Value
        private decimal turnover;    // Turnover
        /* End Variable Declarations */
        
        public InventoryUI()
        {
            InitializeComponent();
        }

        // Exit the program
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Clear all text fields
        private void btn_clear_Click(object sender, EventArgs e)
        {
            tbx_invStart.Clear();
            tbx_invEnd.Clear();
            tbx_invSold.Clear();
            tbx_invAvg.Clear();
            tbx_turnover.Clear();
            tbx_invStart.Focus();
        }

        // Calculate Goods Sold, Average Inventory, and Turnover; and display the results
        private void btn_calc_Click(object sender, EventArgs e)
        {
            if ( calcStats() > 0 ) { return; }
            putStats();
        }

        // Calculate Goods Sold, Average Inventory, and Turnover
        // returns the number of errors
        private int calcStats()
        {
            int errors = getInventory();
            if ( errors == 0 )
            {
                invAvg = calcInvAvg(invStart, invEnd);
                turnover = calcTurnover(invSold, invAvg);
            }
            return errors;
        }

        // Display the Results
        private void putStats()
        {
            tbx_invAvg.Text = invAvg.ToString("c");
            tbx_turnover.Text = turnover.ToString("n1");
        }

        // Get the starting and ending inventory values and value of goods sold from the text boxes
        // Returns zero if there all inputs are valid, else returns the number of errors and displays a message
        private int getInventory()
        {
            int errors = 0; // number of invalid inputs
            try
            {
                invStart = decimal.Parse(tbx_invStart.Text);
                invEnd = decimal.Parse(tbx_invEnd.Text);
                invSold = decimal.Parse(tbx_invSold.Text);
            }
            catch ( FormatException e )
            {
                string nullMsg = "Please enter a valid quantity for ";
                string errMsg = "";
                // Make sure inout is valis an not null
                if ( tbx_invStart.Text == null || tbx_invStart.Text == "" )
                {
                    errMsg = nullMsg + "Starting Inventory";
                    errors++;
                    tbx_invStart.Focus();
                }
                else if ( tbx_invEnd.Text == null || tbx_invEnd.Text == "" )
                {
                    errMsg = nullMsg + "Ending Inventory";
                    errors++;
                    tbx_invEnd.Focus();
                }
                else if ( tbx_invSold.Text == null || tbx_invSold.Text == "" )
                {
                    errMsg = nullMsg + "Goods Sold";
                    errors++;
                    tbx_invSold.Focus();
                }
                if ( errors > 0 ) { MessageBox.Show(errMsg); }
            }
            return errors;

        }

        private decimal calcInvSold ( decimal invStart, decimal invEnd )
        {
            return invStart - invEnd;
        }

        private decimal calcInvAvg ( decimal invStart, decimal invEnd )
        {
            return (invStart + invEnd) / 2;
        }

        private decimal calcTurnover ( decimal invSold, decimal invAvg )
        {
            try
            {
                return invSold / invAvg;
            }
            catch ( DivideByZeroException e ) { return 0; }
        }
    }
}
