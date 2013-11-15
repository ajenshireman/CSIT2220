using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using Lab5;

namespace DiceTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main ()
        {
            Lab5.DiceArray dice = new Lab5.DiceArray(2, 6);
            string results;
            Random rng = new Random();
            do
            {
                int[] result = dice.roll();
                results = "results:";
                for ( int i = 0; i < result.Length; i++ )
                {
                    results += "\n" + result[i];
                }

                results += "\n\nthis.rng\n" + rng.Next(1, 7);

                results += "\n\n Continue?";
            } while ( MessageBox.Show(results, "Continue", MessageBoxButtons.YesNo) == DialogResult.Yes );
        }
    }
}
