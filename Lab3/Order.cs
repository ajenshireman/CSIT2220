/**
 * Order.cs
 * Author: Ajen Shireman
 * Course: CSIT 22220
 * Instructor: Mehdi Negahban
 * 
 * Lab 3
 * Class for holding information for a single order
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSIT2220_Lab3
{
    class Order
    {
        /* Variable Declarations */
        private List<Drink> drinks; // List of drinks in this order
        /* End Variable Declarations */

        /* Constructor */
        public Order ()
        {
            drinks = new List<Drink>();
        }

        // Return true if the order contains drinks
        public bool isValid ()
        {
            if ( drinks.Count > 0 ) { return true; }
            else { return false; }
        }

        // Add a drink to the order
        public void addDrink ( Drink drink )
        {
            drinks.Add(drink);
        }

        // Remove a drink from the order
        public void subtractDrink ( Drink drink )
        {
            drinks.Remove(drink);
        }

        // Return a summary of the order: Number of drinks and the total cost
        public Summary getSummaryBasic ()
        {
            int numDrinks = 0;
            decimal sales = 0m;
            foreach ( Drink d in drinks )
            {
                // Get the price of the drink
                sales += d.getPrice();

                // Increment the number of drinks
                numDrinks++;
            }

            return new Summary(1, numDrinks, sales);
        }
    }
}
