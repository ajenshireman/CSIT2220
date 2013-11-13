/**
 * Dice.cs
 * Author: Ajen Shireman
 * 
 * Class for simulating a single die.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Random;
using System.Text;

namespace Lab5
{
    class Die
    {
        private int    sides;   // Number of sides on the die
        private Random roller;  // RNG for rolling the die

        /* Constructors */
        // Create a die with any number of sides
        public Die ( int sides )
        {
            this.sides = sides;
            roller = new Random();
        }

        // Create a die with 6 sides
        public Die () : this(6)
        {
            
        }

        /* Methods */
        // Roll the bones
        public int roll ()
        {
            return roller.Next(1, sides);
        }
    }
}
