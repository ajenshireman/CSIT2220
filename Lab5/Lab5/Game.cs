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
    public partial class Game : Form
    {
        /* Constants */
        // Messages
        private string MSG_READY = "Roll!";
        private string MSG_ROLLING = "Rolling...";
        private string MSG_WIN = "WIN!";
        private string MSG_LOOSE = "Loose!";

        /* Variable Decarations */
        private Form parent;
        private Dice dice;      // Array containing 2 Dice objects, used to generate rolls
        private int  point;     // Value of first roll
        private bool doReset;   // whether or not to reset the game
        private bool rolling;    // Is a roll in progress?

        public Game ()
        {
            InitializeComponent();
            // Allow Transparent Backgrounds
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            pnlDice.BackColor = Color.Transparent;
            pnlDie1.BackColor = Color.Transparent;
            pnlDie2.BackColor = Color.Transparent;
            lblPoint.BackColor = Color.Transparent;
            lblRoll.BackColor = Color.Transparent;
            lblMessage.BackColor = Color.Transparent;
            btnRoll.BackColor = Color.Transparent;
            btnRoll.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnRoll.FlatAppearance.MouseDownBackColor = Color.Transparent;

            // Create the dice
            dice = new Dice(2, 6);

            // reset the game
            reset();
        }

        public Game ( Form parent )
            : this()
        {
            this.parent = parent;
        }

        /* Event Handlers */
        private void btnRoll_Click ( object sender, EventArgs e )
        {
            if ( doReset )
            {
                reset();
            } 
            else if ( rolling ) {
                roll();
            }
            else {
                shake();
            }
        }

        private void timer1_Tick ( object sender, EventArgs e )
        {
            pnlDie1.BackgroundImage = DieFaces.get(6);
            pnlDie2.BackgroundImage = DieFaces.get(6);
        }

        /* Game Logic */
        // While the dice are being shaken, show random faces on each
        private void shake ()
        {
            lblMessage.Text = MSG_ROLLING;
            rolling = true;
            timer1.Start();
        }

        // Roll the dice
        private void roll ()
        {
            timer1.Stop();
            rolling = false;

            // roll the dice
            int[] result = dice.roll();
            
            // show the appropriate image
            pnlDie1.BackgroundImage = DieFaces.get(6, result[1]);
            pnlDie2.BackgroundImage = DieFaces.get(6, result[2]);
            pnlDie1.Show();
            pnlDie2.Show();

            // get the total and display
            //currentRoll = result[0];
            lblRoll.Text = "Roll: " + result[0];
            lblRoll.Show();

            // caculate the result
            determineResult(result[0]);
        }

        // Determine the reslut of a throw
        private void determineResult ( int currentRoll )
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
                        this.point = currentRoll;
                        lblPoint.Text = "Point: " + point;
                        lblPoint.Show();
                        lblMessage.Text = MSG_READY;
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
                    lblMessage.Text = MSG_READY;
                }
            }
        }

        // Player has won
        private void playerWin ()
        {
            // Show winning message
            lblMessage.Text = MSG_WIN;

            // Reset the game
            doReset = true;
        }

        // Player has lost
        private void playerLoose ()
        {
            // Show Loosing message
            lblMessage.Text = MSG_LOOSE;

            // reset the game
            doReset = true;
        }

        // Reset the game
        private void reset ()
        {
            // Hide stuff that should be hidden
            pnlDie1.BackgroundImage = pnlDie2.BackgroundImage = null;
            lblPoint.Hide();
            lblRoll.Hide();

            // reset point and roll
            point = 0;
            rolling = false;

            // Reset mesage
            lblMessage.Text = MSG_READY;

            // reset has been done
            doReset = false;
        }
    }
}
