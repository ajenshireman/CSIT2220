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

namespace CSIT2220_Lab3
{
    class Drink
    {
        /* Variable Declarations */
        private int type;                   // Type of drink
        private int size;                   // Size of drink
        private List<Additive> additives;   // List of Additives in the drink
        /* End Variable Declarations */

        public Drink ( int type, int size, List<Additive> additives, int quantity )
        {
            this.type = type;
            this.size = size;
            this.additives = additives;
        }

        // Return the price of the currently selected drink
        public decimal getPrice ()
        {
            decimal price = 0;

            // Look trough list of drinks and add price 

            // Look through additives and add price

            return price;
        }
    }
}
