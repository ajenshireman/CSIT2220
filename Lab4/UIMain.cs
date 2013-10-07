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
    public partial class UIMain : Form
    {
        AboutForm about;

        public UIMain ()
        {
            InitializeComponent();
            about = new AboutForm();
        }

        private void btnClose_Click ( object sender, EventArgs e )
        {
            this.Close();
        }

        private void btnAbout_Click ( object sender, EventArgs e )
        {
            about.ShowDialog();
        }

        private void btnAdd_Click ( object sender, EventArgs e )
        {
            string newItem = tbx_newItem.Text;

            if ( newItem == "" )
            {
                MessageBox.Show("Please enter text.");
            }
            else if ( !itemFound(newItem, lbxItems) )
            {
                lbxItems.Items.Add(newItem);
            }
            else
            {
                MessageBox.Show("Item is already in the list");
            }

            tbx_newItem.Clear();
            tbx_newItem.Focus();
        }

        public bool itemFound ( string item, ListBox list ) {
            for ( int i = 0; i < list.Items.Count; i++ )
            {
                if ( (string)list.Items[i] == item )
                {
                    return true;
                }
            }

            return false;
        }

        private void btnClearlbxItems_Click ( object sender, EventArgs e )
        {
            if ( MessageBox.Show("This will clear all items in the ListBox!", "", MessageBoxButtons.OKCancel) == DialogResult.OK )
            {
                lbxItems.Items.Clear();
            }
        }

        private void btnRemove_Click ( object sender, EventArgs e )
        {
            if ( lbxItems.SelectedIndex == -1 )
            {
                MessageBox.Show("Please select an item to remove.");
            }
            else if ( MessageBox.Show("This will remove the selecter item form the ListBox!", "", MessageBoxButtons.OKCancel) == DialogResult.OK )
            {
                lbxItems.Items.RemoveAt(lbxItems.SelectedIndex);
            }
        }

        private void btnCount_Click ( object sender, EventArgs e )
        {
            MessageBox.Show("Items: " + lbxItems.Items.Count);
        }

    }
}
