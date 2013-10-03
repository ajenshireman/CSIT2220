/**
 * Additive.cs
 * Author: Ajen Shireman
 * Course: CSIT 22220
 * Instructor: Mehdi Negahban
 * 
 * Lab 3
 * Stores information about a single additve
 * Builds and returns a list of additives
 * Returns the price of an additive
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSIT2220_Lab3
{
    class Additive
    {
        /* Constants */
        private const decimal DEFAULT_PRICE = 1.00m;

        /* Additive properites */
        private int id;
        private string name;
        private decimal price;

        /* Constructors */
        // Create an Additive with known id, price, and name
        public Additive ( int id, decimal price, string name )
        {
            this.id = id;
            this.price = price;
            this.name = name;
        }

        // Create an Additive with an id and price
        public Additive ( int id, decimal price ) 
        {
            this.id = id;
            this.price = price;
            this.name = "Additive " + id.ToString();
        }

        // Build and return a List of the available additives
        public static List<Additive> getAdditiveList ()
        {
            List<Additive> additiveList = new List<Additive>();

            // Don't worry about names for this lab, it's unnecessary.
            for ( int i = 0; i < 3; i++ )
            {
                additiveList.Add(new Additive(i, DEFAULT_PRICE));
            }

            return additiveList;
        }

        // Return the price of the additive
        public decimal getPrice ()
        {
            return price;
        }
    }
}
