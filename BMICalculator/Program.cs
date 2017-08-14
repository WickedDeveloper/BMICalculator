using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Name: David Gwyn
 * Student #: 821304912
 * Date: August 13th, 2017
 * Description: BMI Calculator application
 * Version: 0.4 - Instantiate the bMICalculator Form Object and Display Splash Screen on Application Load.
*/

namespace BMICalculator
{
    public static class Program
    {
        /// <summary>
        /// Creates a reference to the BMI Calculator Form
        /// </summary>
        public static BMICalculatorForm bMICalculatorForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bMICalculatorForm = new BMICalculatorForm();
            Application.Run(new BMISplashForm());
        }
    }
}
