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
 * Version: 1.2 - Refactored click event for BMIFormResetButton, added comments, and finished final testing of application.
*/

namespace BMICalculator
{
    public partial class BMICalculatorForm : Form
    {
        // PRIVATE INSTANCE VARIABLES

        private double _weight;
        private double _height;
        private double _bmiResult;

        // PUBLIC PROPERTIES

        public double Weight
        {
            get
            {
                return this._weight;
            }

            set
            {
                this._weight = value;
            }
        }

        public double Height
        {
            get
            {
                return this._height;
            }

            set
            {
                this._height = value;
            }
        }

        public double BMIResult
        {
            get
            {
                return this._bmiResult;
            }

            set
            {
                this._bmiResult = value;
            }
        }


        // CONSTRUCTORS

        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        // PRIVATE METHODS

        /// <summary>
        /// Click event for the BMIFormResetButton which calls the BMICalculatorFormReset method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMIFormResetButton_Click(object sender, EventArgs e)
        {
            BMICalculatorFormReset();
        }

        /// <summary>
        /// Clears BMICalculatorForm values and resets form to defaults.
        /// </summary>
        private void BMICalculatorFormReset()
        {
            ImperialRadioButton.Checked = true;
            MyHeightTextBox.Clear();
            MyWeightTextBox.Clear();
            BMIDisplayTextBox.Clear();
            BMIProgressBar.Value = 0;
            BMIResultsTextBox.Clear();
        }

        /// <summary>
        /// Click event for the CalculateBMIButton which calls the CalculateBMIResults methods and DisplayBMIResults method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
           
            CalculateBMIResults();
            DisplayBMIResults();
        }

        /// <summary>
        /// Calculates BMI based on inputs from user for Height and Weight and whether Imperial or Metric radio button is selected.
        /// </summary>
        private void CalculateBMIResults ()
        {
            double height = Convert.ToDouble(MyHeightTextBox.Text);
            double weight = Convert.ToDouble(MyWeightTextBox.Text);
            this.Height = height;
            this.Weight = weight;

            if (ImperialRadioButton.Checked)
            {
                BMIResult = ((Weight * 703) / (Height * Height));
            }

            if(MetricRadioButton.Checked)
            {
                BMIResult = ((Weight) / (Height * Height));
            }
        }

        /// <summary>
        /// Displays BMI results based on BMIResult and changes color of the progress bar.
        /// </summary>
        private void DisplayBMIResults ()
        {
            BMIProgressBar.Minimum = 0;
            BMIProgressBar.Maximum = 100;

            if (BMIResult > 30)
            {
                BMIDisplayTextBox.Text = BMIResult.ToString("0.0");
                BMIResultsTextBox.Text = "Obese, as your BMI Result is 30 or greater!";
                BMIProgressBar.Value = 100;
            }  

            if (BMIResult > 25 && BMIResult <= 29.9)
            {
                BMIDisplayTextBox.Text = BMIResult.ToString("0.0");
                BMIResultsTextBox.Text = "Overweight, as your BMI Result is between 25 and 29.9!";
                BMIProgressBar.Value = 75;
            }

            if (BMIResult > 18.5 && BMIResult <= 24.9)
            {
                BMIDisplayTextBox.Text = BMIResult.ToString("0.0");
                BMIResultsTextBox.Text = "Normal, as your BMI Result is between 18.5 and 24.9!";
                BMIProgressBar.Value = 50;
            }

            if (BMIResult < 18.5)
            {
                BMIDisplayTextBox.Text = BMIResult.ToString("0.0");
                BMIResultsTextBox.Text = "Underweight, as your BMI Result is less than 18.5!";
                BMIProgressBar.Value = 25;
            }
        }

        /// <summary>
        /// Validates MyHeightTextBox so only numeric inputs are accepted.  Also allows backspace and delete key to be used.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyHeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char inputValue = e.KeyChar;

            if (!Char.IsDigit(inputValue) && inputValue != 8 && inputValue != 46)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Validates MyHeightTextBox so only numeric inputs are accepted.  Also allows backspace and delete key to be used.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyWeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char inputValue = e.KeyChar;

            if (!Char.IsDigit(inputValue) && inputValue != 8 && inputValue != 46)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// This event ensures the application closes when the form is closed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // PUBLIC METHODS
    }
}