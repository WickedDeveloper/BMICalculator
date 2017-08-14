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
 * Version: 0.3 - Refactored BMICalculatorForm Public Properties.
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
                return Program.bMICalculatorForm;
            }
        }

        // CONSTRUCTORS
        public BMISplashForm()
        {
            InitializeComponent();
        }

        // PRIVATE METHODS

        private void BMISplashFormTimer_Tick(object sender, EventArgs e)
        {
            this.BMICalculatorForm.Show();
            this.Hide();
            BMISplashFormTimer.Enabled = false; // Turn the timer off
        }

        // PUBLIC METHODS
    }
}
