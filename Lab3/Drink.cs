/**
 * Drink.cs
 * Author: Ajen Shireman
 * Course: CSIT 22220
 * Instructor: Mehdi Negahban
 * 
 * Lab 3
 * Class for holding a single drink
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSIT2220_Lab3
{
    class Drink
    {
        /* Constants */
        public const int NONE             = 0;
        public const int FRUIT            = 1;
        public const int VEGETABLE        = 2;
        public const int POMEGRANATE      = 3;
        public const int STRAWBERRYBANANA = 4;
        public const int WHEATBERRY       = 5;
        /* Variable Declarations */
        private int type;                   // Type of drink
        private int size;                   // Size of drink
        private List<Additive> additives;   // List of Additives in the drink
        /* End Variable Declarations */

        /* Constructors */
        // Create a blank drink
        public Drink ()
        {
            this.type = 0;
            this.size = 0;
            this.additives = new List<Additive>();
        }

        // Create a drink with known type, size, and additives
        public Drink ( int type, int size, List<Additive> additives )
        {
            this.type = type;
            this.size = size;
            this.additives = additives;
        }

        // Return true if both type and size are nonzero
        public bool isValid ()
        {
            if ( type == 0 || size == 0 ) { return false; }
            else { return true; }
        }

        // Set the drink type
        public void setType ( int type )
        {
            //MessageBox.Show(type.ToString());
            this.type = type;
        }

        // Set the drink size
        public void setSize ( int size )
        {
            //MessageBox.Show(size.ToString());
            this.size = size;
        }

        // Add an additive to the drink
        public void addAdditive ( Additive additive )
        {
            // Check to see if the additive is already added

            // If not add it to the drink
            additives.Add(additive);
        }

        // Remove an additive from the drink
        public void removeAdditive ( Additive additive )
        {
            // Check to see if the additive is already added

            // If it is, remove it
            additives.Remove(additive);
        }

        // Return the price of the currently selected drink
        public decimal getPrice ()
        {
            //MessageBox.Show("getting price");
            decimal price = 0;

            // Look trough list of drinks and add price 
            if ( size == 1 )
            {
                price = 3.00m;
            }
            else if ( size == 2 )
            {
                price = 3.50m;
            }
            else if ( size == 3 )
            {
                price = 4.00m;
            }
            // Look through additives and add price
            foreach ( Additive a in additives )
            {
                price += a.getPrice();
            }
            return price;
        }
    }
}
