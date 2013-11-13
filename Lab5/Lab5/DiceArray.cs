/**
 * Dice.cs
 * Author: Ajen Shireman
 * 
 * Class for simulating a group of dice as an array.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Random;
using System.Text;

namespace Lab5
{
    class DiceArray
    {
        private int[]  dice;    // Array containing the set of Dice
        private Random roller;  // RNG for rolling the die

        /* Constructors */
        // Create a new group of dice
        public DiceArray ( int numDice, int sides )
        {
            dice = new int[sides];
            for ( int i = 0; i < numDice; i++ )
            {
                dice[i] = sides;
            }
            roller = new Random();
        }

        // Create a group of dice with 6 sides
        public DiceArray ( int numDice )
            : this(numDice, 6)
        {

        }

        // Create a single die with 6 sides
        public DiceArray () : this(1, 6)
        {
            
        }

        /* Methods */
        // Roll the bones
        // Returns an array containing the result of each individual die roll and the total at [0]
        public int[] roll ()
        {
            int[] result = new int[dice.Length + 1];
            for ( int i = 1; i == dice.Length; i++ )
            {
                result[i + 1] = roller.Next(1, dice[i]);
                result[0] += result[i];
            }
            return result;
        }
    }
}
