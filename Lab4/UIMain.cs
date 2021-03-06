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
    public partial class UIMain : Form
    {
        AboutForm about;
        List<String> items;
        string[] syrupFlavors = { "Hazelnut", "Caramel" };

        public UIMain ()
        {
            InitializeComponent();
            about = new AboutForm();
            items = new List<string>();
            lbxItems.DataSource = items;
            cboCoffeeFlavor.DataSource = items;
            lbxSyrupFlavors.DataSource = syrupFlavors;
            lbxSyrupFlavors.SelectedIndex = -1;
        }

        private void btnClose_Click ( object sender, EventArgs e )
        {
            this.Close();
        }

        private void btnAbout_Click ( object sender, EventArgs e )
        {
            about.ShowDialog();
        }

        private void btnAddItem_Click ( object sender, EventArgs e )
        {
            string newItem = tbx_newItem.Text;

            if ( newItem == "" )
            {
                MessageBox.Show("Please enter text.");
            }
            else if ( !itemFound(newItem, lbxItems) )
            {
                items.Add(newItem);
            }
            else
            {
                MessageBox.Show("Item is already in the list");
            }

            refreshItems();
            tbx_newItem.Clear();
            tbx_newItem.Focus();
        }

        public bool itemFound ( string item, ListBox list ) {
            for ( int i = 0; i < items.Count; i++ )
            {
                if ( items[i] == item )
                {
                    return true;
                }
            }

            return false;
        }

        private void btnClearItems_Click ( object sender, EventArgs e )
        {
            if ( MessageBox.Show("This will clear all items in the ListBox!", "", MessageBoxButtons.OKCancel) == DialogResult.OK )
            {
                items.Clear();
            }

            refreshItems();
        }

        private void btnRemoveItem_Click ( object sender, EventArgs e )
        {
            if ( lbxItems.SelectedIndex == -1 )
            {
                MessageBox.Show("Please select an item to remove.");
            }
            else if ( MessageBox.Show("This will remove the selecter item form the ListBox!", "", MessageBoxButtons.OKCancel) == DialogResult.OK )
            {
                items.Remove(lbxItems.Items[lbxItems.SelectedIndex].ToString());
            }

            refreshItems();
        }

        private void refreshItems ()
        {
            lbxItems.DataSource = null;
            lbxItems.DataSource = items;
            lbxItems.Refresh();
            cboCoffeeFlavor.DataSource = null;
            cboCoffeeFlavor.DataSource = items;
            cboCoffeeFlavor.Refresh();
        }

        private void btnCountItems_Click ( object sender, EventArgs e )
        {
            MessageBox.Show("Items: " + lbxItems.Items.Count);
        }

        private void btnClearDrink_Click ( object sender, EventArgs e )
        {
            cboCoffeeFlavor.SelectedIndex = -1;
            lbxSyrupFlavors.SelectedIndex = -1;
        }

    }
}
