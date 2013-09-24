/**
 * UIMain.cs
 * Author: Ajen Shireman
 * CSIT 2220 Lab 2
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSIT2220_Lab2
{
    public partial class UIMain : Form
    {
        #region Constants
        /* Constants */
        // Violator types
        private const int VISITOR  = 0; // Violator is a Visitor
        private const int EMPLOYEE = 1; // Viloator is Faculty or Staff
        private const int STUDENT  = 2; // Violator is a Student

        // Violator type names
        private string[] VIOLATOTR_TYPES = { "Visitor", "Faculty/Staff", "Student" };

        // Student types
        private const int NONE     = -1; // Violator is not a student
        private const int FRESHMAN =  0; // Student is a Freshman
        private const int SOPHMORE =  1; // Student is a Sophmore
        private const int JUNIOR   =  2; // Student is a Jonior
        private const int SENIOR   =  3; // Student is a Senior
        
        // Student type names
        private string[] STUDENT_TYPE = { "Freshman", "Sophmore", "Junior", "Senior" };

        // Fees
        private const decimal FEE_VISITOR_BASE  = 20.00m; // Base fee for Visitors
        private const decimal FEE_VISITOR_EXT   =  0.00m; // Extra fee for Visitors for each RATE mph over the speed limit
        private const int     FEE_VISITOR_RATE  = 0;      // Rate at which extra fees are added: every RATE mph over the speed limit. If this is 0, no extra fees shoud be added
        private const decimal FEE_EMPLOYEE_BASE = 75.00m; // Base fee for Faculty and Staff
        private const decimal FEE_EMPLOYEE_EXT  = 30.00m; // Extra fee for Faculty and Staff for each RATE mph over the speed limit
        private const int     FEE_EMLOYEE_RATE  = 5;      // Rate at which extra fees are added: every RATE mph over the speed limit. If this is 0, no extra fees shoud be added
        private const decimal FEE_STUDENT_BASE  = 75.00m; // Base fee for Students
        private const decimal FEE_STUDENT_EXT   = 87.50m; // Extra fee for Students for each RATE mph over the speed limit
        private const int     FEE_STUDENT_RATE  = 5;      // Rate at which extra fees are added: every RATE mph over the speed limit. If this is 0, no extra fees shoud be added

        // Arrays to hold fee info. Makes caculating fees simpler.
        private decimal[] FEE      = { FEE_VISITOR_BASE, FEE_EMPLOYEE_BASE, FEE_STUDENT_BASE };
        private decimal[] FEE_EXT  = { FEE_VISITOR_EXT, FEE_EMPLOYEE_EXT, FEE_STUDENT_EXT };
        private int[]     FEE_RATE = { FEE_VISITOR_RATE, FEE_EMLOYEE_RATE, FEE_STUDENT_RATE };

        // Extra fees for students
        private const int     MPH_RECKLESS        = 20;       // Threshod for reckless driving. Students traveing more than this amount over the speed limit must pay an additional fine
        private const decimal FEE_RECKLESS        = 100.00m;  // Fine for reckless driving
        private const decimal FEE_RECKLESS_SENIOR = 200.00m;  // Fine for reckess driving, seniors only
        private const decimal FEE_EXTRA_SENIOR    =  50.00m;  // Additional fee for Seniors, who should know better
        private const decimal FEE_EXTRA_FRESHMAN  = -50.00m;  // Additional fee for Freshmen. Negative because we're going to cut them some slack.
        /* End Constants */
        #endregion

        #region Variable Declarations
        /* Variable Declarations */
        private int     violatorType;   // Visitor, Faculty/Staff, or Student
        private int     studentYear;    // Freshman, Sophmore, Junior, Senior
        private int     speedLimit;     // Speed Limit at violation location. Changed by rbt_limit35 and rbt_limit15
        private int     clockedSpeed;   // Speed the vioator was traveling at
        private int     speedOver;      // Amount violator was traveling over the posted limit
        private decimal feeBase;        // Base fee for the violation
        private decimal feeExt;         // Extended fee for amount over the Limit
        private decimal feeReckless;    // Fee for reckless driving
        private decimal feeAdditional;  // Additional fees
        private decimal feeTotal;       // Total fine
        /* End Variable Decarations */
        #endregion

        public UIMain()
        {
            InitializeComponent();
        }

        // Clear all input and output fields
        private void btn_clear_Click ( object sender, EventArgs e )
        {
            tbx_clockedSpeed.Clear();
            tbx_speedOver.Clear();
            tbx_feeBase.Clear();
            tbx_feeExt.Clear();
            tbx_feeReckless.Clear();
            tbx_additional.Clear();
            tbx_feeTotal.Clear();
            cbo_violatorType.SelectedIndex = -1;
            cbo_studentYear.SelectedIndex = -1;
        }

        /* Calculate the fine */
        private void btn_calcFine_Click ( object sender, EventArgs e )
        {
            // Clear current fines
            clearFine();

            // Get violation information
            try
            {
                clockedSpeed = int.Parse(tbx_clockedSpeed.Text);
            }
            catch ( FormatException ex )
            {
                MessageBox.Show("Please enter a Clocked Speed");
                return;
            }
            // Make sure violator information is present
            if ( cbo_violatorType.SelectedIndex == -1 )
            {
                MessageBox.Show("Please select a violator type");
                return;
            }
            else if ( cbo_violatorType.SelectedIndex == STUDENT && cbo_studentYear.SelectedIndex == -1 )
            {
                MessageBox.Show("Please select a student year.");
                return;
            }

            // Calculate the fine
            caculateFee(clockedSpeed, speedLimit, violatorType, studentYear);

            // Output fine information
            printFine();
        }

        // Reset all fees to 0
        private void clearFine ()
        {
            feeBase = feeExt = feeReckless = feeAdditional = feeTotal = 0;
        }

        // Determine violator type and calculate fine accordingly
        private void caculateFee ( int clockedSpeed, int speedLimit, int violatorType, int studentYear )
        {
            if ( clockedSpeed <= speedLimit ) { clearFine(); return; }
            // Check Vioator's status and calculate the apprpriate fee
            // Always apply the base fee
            caculateBasicFee(clockedSpeed, speedLimit, violatorType);
            // Additional fees if the violator is a student
            if ( violatorType == STUDENT ) { 
                calculateStudentFee(clockedSpeed, speedLimit, studentYear); 
            }
        }

        // Simple fee structure. Base fee + extra for every x mph over the speed limit
        private void caculateBasicFee ( int clockedSpeed, int speedLimit, int violatorType )
        {
            feeBase = FEE[violatorType];
            // If the violator should not be charged based on speed, return the base fee
            if ( FEE_RATE[violatorType] == 0 || FEE_EXT[violatorType] == 0 )
            {
                feeTotal = feeBase;
            }
            else
            {
                feeBase = FEE[violatorType];
                speedOver = clockedSpeed - speedLimit;
                int extMult = speedOver / FEE_RATE[violatorType];
                feeExt = FEE_EXT[violatorType] * extMult;
                feeTotal = feeBase + feeExt;
            }
        }

        // More complex fee structure for students. Additional fine for going more than 20mph over the limit, plus additional fees/discounts based on year.
        private void calculateStudentFee ( int clockedSpeed, int speedLimit, int studentYear )
        {
            if ( studentYear == NONE ) { feeTotal = FEE_VISITOR_BASE; }  // Student has not been assigned a year. Let's assume they're a Visitor instead.

            // Seniors get hit hard
            if ( studentYear == SENIOR )
            {
                if ( speedOver > MPH_RECKLESS )
                {
                    feeReckless =  FEE_RECKLESS_SENIOR;
                }
                else
                {
                    feeAdditional += FEE_EXTRA_SENIOR;
                }
            }
            // Everyone else only gets it if they were going REALLY fast
            else if ( speedOver > MPH_RECKLESS )
            {
                feeReckless = FEE_RECKLESS;
            }
            // Freshmen who weren't going REALLY fast get a break
            else if ( studentYear == FRESHMAN )
            {
                feeAdditional = FEE_EXTRA_FRESHMAN;
            }

            feeTotal = feeBase + feeExt + feeReckless + feeAdditional;

        }

        // Output fine information
        private void printFine ()
        {
            tbx_speedOver.Text = speedOver.ToString();
            tbx_feeBase.Text = feeBase.ToString("c");
            tbx_feeExt.Text = feeExt.ToString("c");
            tbx_feeReckless.Text = feeReckless.ToString("c");
            tbx_additional.Text = feeAdditional.ToString("c");
            tbx_feeTotal.Text = feeTotal.ToString("c");
        }

        /* Eventhanders for information input */
        // Speed Limit radio buttons
        private void rbt_limit35_CheckedChanged ( object sender, EventArgs e )
        {
            speedLimit = 35;
        }

        private void rbt_limit15_CheckedChanged ( object sender, EventArgs e )
        {
            speedLimit = 15;
        }

        private void cbo_violatorType_SelectedIndexChanged ( object sender, EventArgs e )
        {
            violatorType = cbo_violatorType.SelectedIndex;
            // Unlock the Student type combo box if the violator is a student, otherwise lock it
            if ( violatorType == STUDENT )
            {
                cbo_studentYear.Enabled = true;
            }
            else
            {
                cbo_studentYear.Enabled = false;
                cbo_studentYear.SelectedIndex = -1;
            }

        }

        private void cbo_studentYear_SelectedIndexChanged ( object sender, EventArgs e )
        {
            studentYear = cbo_studentYear.SelectedIndex;
        }

    }
}
