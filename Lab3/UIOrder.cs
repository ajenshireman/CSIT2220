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
        /* Constants */
        private const int DEFAULT_DRINK_QUANTITY = 1;

        /* Lists containing the drink type and size selection radio buttons */
        private List<RadioButton> drinkTypeRadioButtons;
        private List<RadioButton> drinkSizeRadioButtons;

        /* List containing the available addatives */
        private List<Additive> additiveList;

        /* Variable Declarations */
        private Day currentDay;
        private Order currentOrder;
        private Drink currentDrink;
        private int drinkQuantity;
        /* End Variable Declarations */

        public uiMain()
        {
            InitializeComponent();
            startup();
        }

        #region ConstructorMethods
        private void startup () {
            InitializeDrinkTypeRadioButtons();
            InitializeDrinkSizeRadioButtons();
            InitializeAdditives();
            currentDay = new Day();
            currentOrder = new Order();
            currentDrink = new Drink();
            updateDrinkQuantity(DEFAULT_DRINK_QUANTITY);
            updateDrink();
            updateOrder();
        }

        // Add the drink type radio buttons to the List, wire up the event hander, and make sure only 'none' is selected
        private void InitializeDrinkTypeRadioButtons ()
        {
            this.drinkTypeRadioButtons = new List<RadioButton>();
            this.drinkTypeRadioButtons.Add(this.rbtTypeNone);
            this.drinkTypeRadioButtons.Add(this.rbtTypeFruit);
            this.drinkTypeRadioButtons.Add(this.rbtTypeVegetable);
            this.drinkTypeRadioButtons.Add(this.rbtTypePomegranate);
            this.drinkTypeRadioButtons.Add(this.rbtTypeStrawberryBanana);
            this.drinkTypeRadioButtons.Add(this.rbtTypeWheatBerry);

            // Add the event handler to the radio buttons.
            foreach ( RadioButton r in drinkTypeRadioButtons )
            {
                r.Click += rbtType_Click;
            }

            setDrinkType(rbtTypeNone);
        }

        // Add the drink size radio buttons to the List, wire up the event hander, and make sure only 'none' is selected
        private void InitializeDrinkSizeRadioButtons ()
        {
            this.drinkSizeRadioButtons = new List<RadioButton>();
            this.drinkSizeRadioButtons.Add(this.rbtSizeNone);
            this.drinkSizeRadioButtons.Add(this.rbtSize12);
            this.drinkSizeRadioButtons.Add(this.rbtSize16);
            this.drinkSizeRadioButtons.Add(this.rbtSize20);

            // Add the event handler to the radio buttons.
            foreach ( RadioButton r in drinkSizeRadioButtons )
            {
                r.Click += rbtSize_Click;
            }

            setDrinkSize(rbtSizeNone);
        }

        // Get a List of available additives
        private void InitializeAdditives ()
        {
            additiveList = Additive.getAdditiveList();
        }
        #endregion

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
        private void helpToolStripMenuItem1_Click ( object sender, EventArgs e )
        {
            showHelpDialog();
        }

        private void aboutToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            showAboutDialog();
        }
        /* End menu */

        /* Buttons */
        // Drink
        private void btnDrinkAdd_Click ( object sender, EventArgs e )
        {
            addDrink();
        }

        private void btnDrinkClear_Click ( object sender, EventArgs e )
        {
            clearDrink();
        }

        private void tbxDrinkQuantity_TextChanged ( object sender, EventArgs e )
        {
            updateDrinkTotal();
        }

        // Order
        private void btnOrderSubmit_Click ( object sender, EventArgs e )
        {
            submitOrder();
        }

        private void btnOrderClear_Click ( object sender, EventArgs e )
        {
            clearOrder();
        }
        /* End Buttons */

        /* Drink Selection */
        // Drink Type
        private void rbtType_Click ( object sender, EventArgs e )
        {
            setDrinkType(sender);
        }

        // Drink Size
        private void rbtSize_Click ( object sender, EventArgs e )
        {
            setDrinkSize(sender);
        }
        /* End drink selection */

        /* Additive selection */
        private void rbtAddVitaminPack_CheckedChanged ( object sender, EventArgs e )
        {
            if ( cbxAddVitaminPack.Checked )
            {
                // Add Vitamin Pack to currentDrink
                currentDrink.addAdditive(additiveList[0]);
            }
            else
            {
                // Remove Vitamin Pack from curretnDrink
                currentDrink.removeAdditive(additiveList[0]);
            }
            updateDrink();
        }

        private void rbtAddEnergyBooster_CheckedChanged ( object sender, EventArgs e )
        {
            if ( cbxAddEnergyBooster.Checked )
            {
                // Add Energy Booster to currentDrink
                currentDrink.addAdditive(additiveList[1]);
            }
            else
            {
                // Remove Energy Booster from curretnDrink
                currentDrink.removeAdditive(additiveList[1]);
            }
            updateDrink();
        }

        private void rbtAddCoolDownRemedey_CheckedChanged ( object sender, EventArgs e )
        {
            if ( cbxAddCoolDownRemedey.Checked )
            {
                // Add Cool Down Remedey to currentDrink
                currentDrink.addAdditive(additiveList[2]);
            }
            else
            {
                // Remove Cool Down Remedey from curretnDrink
                currentDrink.removeAdditive(additiveList[2]);
            }
            updateDrink();
        }
        /* End Additive selection */
        #endregion

        // Show a summary of the day's orders
        private void generateDailySummary ()
        {
            currentDay.getSummaryBasic();
        }

        // Add the current drink to the current order
        private void addDrink ()
        {
            if ( currentDrink.isValid() )
            {
                for ( int i = 0; i < drinkQuantity; i++ )
                {
                    currentOrder.addDrink(currentDrink);
                }
                updateOrder();
                clearDrink();
            }
            else
            {
                MessageBox.Show("Please select a size and type of drink");
            }
        }

        // Reset the current drink
        private void clearDrink ()
        {
            currentDrink = new Drink();
            updateDrinkQuantity(DEFAULT_DRINK_QUANTITY);
            setDrinkSize(rbtSizeNone);
            setDrinkType(rbtTypeNone);
            cbxAddVitaminPack.Checked = false;
            cbxAddEnergyBooster.Checked = false;
            cbxAddCoolDownRemedey.Checked = false;
            updateDrink();
        }

        // Add the current order to the current day
        private void submitOrder ()
        {
            if ( currentOrder.isValid() )
            {
                if ( currentDrink.isValid() )
                {
                    // A drink has been selected, but has not been added to the order
                    // Ask the user if they want to add the drink, submit the order without the drink, or cancel order submission
                    // For this lab, just tell the user to do it themselves
                    string msg = "You have not added the currently selected drink to your order.\n" + 
                                 "Please add the drink to your order or clear the drink to continue.";
                    MessageBox.Show(msg);
                }
                else
                {
                    currentDay.addOrder(currentOrder);
                    clearOrder();
                }
            }
            else
            {
                MessageBox.Show("Please add add at least one drink to your order");
            }
        }

        // Reset the current order
        private void clearOrder ()
        {
            clearDrink();
            currentOrder = new Order();
            updateOrder();
        }

        // Update the displayed order information
        private void updateOrder ()
        {
            // Get Order summary
            Summary s = currentOrder.getSummaryBasic();

            // Print number of drinks and order total
            tbxOrderItems.Text = s.drinks.ToString();
            tbxOrdertTotal.Text = s.sales.ToString("c");
        }

        private void setDrinkType ( Object selection )
        {
            // Check the correct radio button
            foreach ( RadioButton r in drinkTypeRadioButtons )
            {
                if ( r == selection )
                {
                    r.Checked = true;
                }
                else
                {
                    r.Checked = false;
                }
            }

            try
            {
                // Set the appropriate drink Type
                if ( selection == rbtTypeNone )
                {
                    currentDrink.setType(Drink.NONE);
                }
                else if ( selection == rbtTypeFruit )
                {
                    currentDrink.setType(Drink.FRUIT);
                }
                else if ( selection == rbtTypeVegetable )
                {
                    currentDrink.setType(Drink.VEGETABLE);
                }
                else if ( selection == rbtTypePomegranate )
                {
                    currentDrink.setType(Drink.POMEGRANATE);
                }
                else if ( selection == rbtTypeStrawberryBanana )
                {
                    currentDrink.setType(Drink.STRAWBERRYBANANA);
                }
                else if ( selection == rbtTypeWheatBerry )
                {
                    currentDrink.setType(Drink.WHEATBERRY);
                }

                updateDrink();
            }
            catch ( NullReferenceException )
            {

            }
        }

        private void setDrinkSize ( Object selection )
        {
            // Check the correct radio button
            foreach ( RadioButton r in drinkSizeRadioButtons )
            {
                if ( r == selection )
                {
                    r.Checked = true;
                }
                else
                {
                    r.Checked = false;
                }
            }

            try
            {
                if ( selection == rbtSize12 )
                {
                    currentDrink.setSize(1);
                }
                else if ( selection == rbtSize16 )
                {
                    currentDrink.setSize(2);
                }
                else if ( selection == rbtSize20 )
                {
                    currentDrink.setSize(3);
                }
                else
                {
                    currentDrink.setSize(0);
                }
                updateDrink();
            }
            catch ( NullReferenceException )
            {

            }
        }

        // Update te displayed drink infrormation
        private void updateDrink ()
        {
            //if ( !currentDrink.isValid() ) { return; }
            tbxDrinkPrice.Text = currentDrink.getPrice().ToString("c");
            updateDrinkTotal();
        }

        // Update the total cost of the current drink
        private void updateDrinkTotal ()
        {

            decimal drinkPrice = currentDrink.getPrice();
            try
            {
                drinkQuantity = int.Parse(tbxDrinkQuantity.Text);
            }
            catch ( FormatException e )
            {
                // ignore
            }
            decimal drinkTotal = drinkPrice * drinkQuantity;
            tbxDrinkTotal.Text = drinkTotal.ToString("c");
        }

        // Update the quantity of the current drink
        private void updateDrinkQuantity ( int newQuantity )
        {
            tbxDrinkQuantity.Text = newQuantity.ToString();
            //updateDrinkTotal();
        }

        private void updateDrinkQuantity ( string newQuantity )
        {
            updateDrinkTotal();
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

        private void showAboutDialog ()
        {
            string msg = "CSIT 2220 Lab 3\n" + 
                         "Author: Ajen Shireman\n\n" + 
                         "Drink order form";

            MessageBox.Show(msg, "About");
        }

        private void showHelpDialog () {
            string msg = "Select drink type, size, additives, and quantity.\n" + 
                         "Select \"Add to Order\" to add the current drink(s) to your order or \"Clear Drink\" to clear the current selection.\n" + 
                         "Select \"Submit Order\" to confirm your order or \"Clear Order\" to start over.\n" + 
                         "A summary of all orders can be accessed form the File menu.";

            MessageBox.Show(msg, "Help");
        }
    }
}
