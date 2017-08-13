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
 * Version: 0.4 - Added public instance variables and public properties for the BMI Calculator Class.
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
    }
}