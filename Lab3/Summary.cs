/**
 * Summary.cs
 * Author: Ajen Shireman
 * Course: CSIT 22220
 * Instructor: Mehdi Negahban
 * 
 * Lab 3
 * Class for storing summary data
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSIT2220_Lab3
{
    struct Summary
    {
        public int orders;     // Number of orders processed
        public int drinks;     // Number of drinks sold
        public decimal sales;  // Sales value in dollars

        public Summary ( int orders, int drinks, decimal sales )
        {
            this.orders = orders;
            this.drinks = drinks;
            this.sales = sales;
        }
    }
}
