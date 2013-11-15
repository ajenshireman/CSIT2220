/**
 * Dice.cs
 * Author: Ajen Shireman
 * 
 * Class for simulating a single die.
 * 
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Lab5
{
    class Die
    {
        /* Class Variables */
        private static Random roller = new Random();  // RNG for rolling the die

        /* Instance Variables */
        private int                 sides;      // Number of sides on the die
        //private int                 roll;       // The die's current roll;
        //private System.Drawing.Image faceImage; // Image corresponding to the die's current roll
        
        /* Constructors */
        // Create a die with any number of sides
        public Die ( int sides )
        {
            this.sides = sides;
        }

        // Create a die with 6 sides
        public Die () : this(6)
        {
            
        }

        /* Methods */
        // Roll the bones
        public int roll ()
        {
            return roller.Next(1, sides + 1);
        }
    }
}
