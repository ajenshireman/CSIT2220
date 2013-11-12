using System;
using System.Collections.Generic;
using System.Linq;
using System.Random;
using System.Text;

namespace Lab5
{
    class Dice
    {
        private int sides; // Number of sides on the die
        private Random roller; // RNG for rolling the die

        /* Constructors */
        // Creates a die with 6 sides
        public Dice () : this(6)
        {
            
        }

        // Creates a die with any number of sides
        public Dice ( int sides )
        {
            this.sides = sides;
            roller = new Random();
        }

        /* Methods */
        // Roll the bones
        public int roll ()
        {
            return roller.Next();
        }
    }
}
