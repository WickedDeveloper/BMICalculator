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
 * Date: August 43th, 2017
 * Description: BMI Calculator application
 * Version: 0.2 - Refactored the BMIResetButton_Click method to reset the BMIProgressBar.
*/

namespace BMICalculator
{
    public partial class BMICalculatorForm : Form
    {
        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Resets all BMICalculatorForm controls back to defaults from initial form load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMIFormResetButton_Click(object sender, EventArgs e)
        {
            ImperialRadioButton.Checked = true;
            MyHeightTextBox.Text = "";
            MyWeightTextBox.Text = "";
            BMIDisplayTextBox.Text = "";
            BMIProgressBar.Value = 0;
            BMIResultsTextBox.Text = "";
        }
    }
}