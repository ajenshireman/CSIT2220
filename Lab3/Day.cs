/**
 * Day.cs
 * Author: Ajen Shireman
 * Course: CSIT 22220
 * Instructor: Mehdi Negahban
 * 
 * Lab 3
 * Class for keping track of the orders for each day
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSIT2220_Lab3
{
    class Day
    {
        /* Variable Declarations */
        private DateTime date;      // The day's date
        private List<Order> orders; // List for storing the day's orders
        /* End Variable Declarations */

        /* Constructor */
        // Create a new Day for the current date.
        Day ()
        {
            date = DateTime.Now;
        }

        /* Public Methods */
        // Add a new Order to the day
        public void addOrder ( Order order )
        {
            orders.Add(order);
        }

        // Show the summary for the day
        // returns a summary object containing the number of drinks sold, the number of orders and the total dollar amount
        public Summary getSummaryBasic ()
        {
            int numOrders = 0;
            int numDrinks = 0;
            decimal sales = 0m;
            foreach ( Order o in orders )
            {
                // Get the order Summary
                Summary s = o.getSummaryBasic();

                // Get number of drinks in the order
                numDrinks += s.drinks;

                // Get value of the order
                sales += s.sales;

                // Incement number of orders
                numOrders++;
            }
            return new Summary(numOrders, numDrinks, sales);
        }
    }
}
