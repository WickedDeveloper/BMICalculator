using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Name: David Gwyn
 * Student #: 821304912
 * Date: August 13th, 2017
 * Description: BMI Calculator Splash Form
 * Version: 0.4 - Finialized BMISplashForm Design, and finished Testing.
*/

namespace BMICalculator
{
    public partial class BMISplashForm : Form
    {
        // PRIVATE INSTANCE VARIABLES

        // PUBLIC PROPERTIES

        public BMICalculatorForm BMICalculatorForm
        {
            get
            {
                return Program.BMICalculatorForm;
            }
        }

        // CONSTRUCTORS
        public BMISplashForm()
        {
            InitializeComponent();
        }

        // PRIVATE METHODS

        /// <summary>
        /// This is the Event Handler for the "Tick" Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMISplashFormTimer_Tick(object sender, EventArgs e)
        {
            this.BMICalculatorForm.Show();
            this.Hide();
            BMISplashFormTimer.Enabled = false; // Turn the timer off
        }

        // PUBLIC METHODS
    }
}
