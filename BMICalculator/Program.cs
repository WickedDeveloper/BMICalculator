﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Name: David Gwyn
 * Student #: 821304912
 * Date: August 13th, 2017
 * Description: BMI Calculator application
 * Version: 0.6 - Finalize comments, and testing on driver class.
*/

namespace BMICalculator
{
    public static class Program
    {
        /// <summary>
        /// Creates a reference to the BMI Calculator Form
        /// </summary>
        public static BMICalculatorForm BMICalculatorForm;

        /// <summary>
        /// The main entry point for the application.  Instantiates a BMICalculatorForm object and displays BMISplashScreen.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BMICalculatorForm = new BMICalculatorForm();
            Application.Run(new BMISplashForm());
        }
    }
}
