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
 * Version: 0.5 - Added validation for MyHeightTextBox and MyWeightTextBox so only numeric values are accepted.
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

        public double BmiResult
        {
            get
            {
                return this._bmiResult;
            }

            set
            {
                this._bmiResult = this._weight * this._height;
            }
        }


        // CONSTRUCTORS

        // PUBLIC METHODS

        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        // PRIVATE METHODS

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

        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            
            //CalculateBMI(MyHeightTextBox.Text, MyWeightTextBox);
        }

        private void CalculateBMI (double height, double weight)
        {
            this.Height = height;
            this.Weight = weight;
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
    }
}