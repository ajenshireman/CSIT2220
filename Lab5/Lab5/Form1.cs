using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        /* Variable Decarations */
        private Dice dice;        // Array containing 2 Dice objects, used to generate rolls
        private int  point;       // Value of first roll
        private int  currentRoll; // Value of most recent roll

        public Form1 ()
        {
            InitializeComponent();
            dice = new Dice(2, 6);
        }

        /* Event Handlers */


        /* Game Logic */
        // Start a new game
        private void start ()
        {
            // hide the start button

            // enable the roll button

            // set the point value to 0 and make sure it is hidden
            point = 0;
            currentRoll = 0;

        }

        // Roll the dice
        private void roll ()
        {
            // roll the dice
            dice.roll();

            // the result as an array
            int[] results = dice.getRoll();

            // show the appropriate image

            // get the total and display
            currentRoll = dice.getRollTotal();

            // caculate the result
            determineResult();
        }

        // Determine the reslut of a throw
        private void determineResult ()
        {
            // first throw
            if ( point <= 0 )
            {
                switch ( currentRoll )
                {
                    case 7:
                    case 11:
                        // Win!
                        playerWin();
                        break;
                    case 2:
                    case 3:
                    case 12:
                        // Loose
                        playerLoose();
                        break;
                    default:
                        // set point and let player continue
                        point = currentRoll;

                        break;
                }
            }
            else
            {
                // player tries to match point before rolling a 7
                if ( currentRoll == point )
                {
                    // win
                    playerWin();
                }
                else if ( currentRoll == 7 )
                {
                    // Loose
                    playerLoose();
                }
                else
                {
                    // Continue

                }
            }
        }

        // Player has won
        private void playerWin ()
        {
            // Show winning message

            // Reset the game
            reset();
        }

        // Player has lost
        private void playerLoose ()
        {
            // Show Loosing message

            // reset the game
            reset();
        }

        // Reset the game
        private void reset ()
        {
            // hide the roll button

            // show the pay button

        }
    }
}
