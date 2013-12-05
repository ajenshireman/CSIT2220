using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab7
{
    public partial class BookingForm : Form
    {
        /* Constants */
        private const int FIRSTCLASS = 1;
        private const int ECONOMY = 2;
        private static Random rng = new System.Random();

        public BookingForm ()
        {
            InitializeComponent();
        }

        private void btnBookFlight_Click ( object sender, EventArgs e )
        {
            bookFlight();
        }

        private void btnCancel_Click ( object sender, EventArgs e )
        {
            clearFields();
        }

        // Clear all the input fields
        private void clearFields ()
        {
            tbxNameFirst.ResetText();
            tbxNameLast.ResetText();
            tbxOrigin.ResetText();
            tbxDestination.ResetText();
            dtpFlighDate.ResetText();
        }

        // Do the stuff to book the flight
        private void bookFlight ()
        {
            // Get the information
            string nameFirst = tbxNameFirst.Text;
            string nameLast = tbxNameLast.Text;
            string origin = tbxOrigin.Text;
            string destination = tbxDestination.Text;
            DateTime departure = dtpFlighDate.Value;

            // Assign a seat
            int seatNumber = 0;
            string section = "";
            if ( rbtFirstClass.Checked )
            {
                seatNumber = getSeatNumber(FIRSTCLASS);
                section = "First Class";
            }
            else if ( rbtEconomy.Checked )
            {
                seatNumber = getSeatNumber(ECONOMY);
                section = "Economy";
            }
            else
            {
                MessageBox.Show("Please select First Class or Ecomnomy.");
            }

            // Get the flight number
            int filghtNumber = getFlightNumber();

            // print the ticket
            string ticket = "Last Name: " + nameLast + "\tFirst Name: " + nameFirst + "\n\n" +
                            "Origin: " + origin + "\tDestination: " + destination + "\n\n" +
                            "Fight Number: " + filghtNumber.ToString() + "\n" + 
                            "Departure: " + departure.ToString() + "\n\n" +
                            "Section: " + section + "\n" +
                            "Seat Number: " + seatNumber.ToString() + "\n";
            tbxBordingPass.Text = ticket;

            // Clear the input
            clearFields();
        }

        // Pick a seat
        private int getSeatNumber ( int section )
        {
            switch ( section )
            {
                case FIRSTCLASS:
                    return rng.Next(1, 4);
                case ECONOMY:
                    return rng.Next(5, 10);
                default:
                    return 0;
            }
        }

        // Get the fight number
        private int getFlightNumber ()
        {
            return rng.Next(100, 999);
        }
    }
}
