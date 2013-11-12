/**
 * Dice.cs
 * Author: Ajen Shireman
 * 
 * Class for simulating a group of dice.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Random;
using System.Text;

namespace Lab5
{
    class Dice
    {
        private int    numDice;   // Number of dice in the set
        private int    sides;     // Number of sides on each die
        private int[]  results    // Result of the roll
        private Random roller;    // RNG for rolling the die

        /* Constructors */
        // Create a new group of dice
        public Dice ( int numDice, int sides )
        {
            this.sides = sides;
            this.numDice = numDice;
            roller = new Random();
        }

        // Create a group of dice with 6 sides
        public Dice ( int numDice )
            : this(numDice, 6)
        {

        }

        // Create a single die with 6 sides
        public Dice () : this(1, 6)
        {
            
        }

        /* Methods */
        // Roll the bones
        public void roll ()
        {
            for ( int i = 0; i < numDice; i++ )
            {
                results[i] = roller.Next(1, sides);
            }
        }

        // Return the result as an array with each separate roll
        public int[] getRoll () 
        {
            int[] resultsCopy = new int[numDice];
            results.CopyTo(resultsCopy, 0);
            return resultsCopy; 
        }

        // Only return the total
        public int getRollTotal ()
        {
            int total = 0;
            for ( int i = 0; i < numDice; i++ ) 
            {
                total += results[i];
            }
            return total;
        }
    }
}
