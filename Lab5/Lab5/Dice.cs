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
using System.Text;

namespace Lab5
{
    public class Dice
    {
        private Die[] dice; // Array containing the set of Dice

        /* Constructors */
        // Create a new group of dice
        public Dice ( int numDice, int sides )
        {
            dice = new Die[numDice];
            for ( int i = 0; i < numDice; i++ )
            {
                dice[i] = new Die(sides);
            }
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
        // Returns an array containing the result of each individual die roll and the total at [0]
        public int[] roll ()
        {
            int[] result = new int[dice.Length + 1];
            for ( int i = 0; i < dice.Length; i++ )
            {
                result[i + 1] = dice[i].roll();
                result[0] += result[i + 1];
            }
            return result;
        }
    }
}
