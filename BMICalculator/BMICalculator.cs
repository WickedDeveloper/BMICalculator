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
 * Description: BMI Calculator application
 * Version: 0.3 - Refactored the BMIResetButton_Click method to reset text boxes using the clear method.
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
            MyHeightTextBox.Clear();
            MyWeightTextBox.Clear();
            BMIDisplayTextBox.Clear();
            BMIProgressBar.Value = 0;
            BMIResultsTextBox.Clear();
        }
    }
}