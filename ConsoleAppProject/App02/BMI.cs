using System;
using System.Text;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This app will use the body weight and height to calculate BMI Index
    /// then classify the health risk.
    /// User can input Imperial or Metric Unit.
    /// </summary>
    /// <author>
    /// Ali Hassan version 0.3
    /// </author>
    public class BMI
    {
        //Bmi Index result
        public double BmiIndex { get; set; }

        //Weight and Height Units
        public int Stone { get; set; }
        public int Pound { get; set; }
        public int Feet { get; set; }
        public int Inch { get; set; }
        public double Centimetres { get; set; }
        public double Kilograms { get; set; }

        public double Metres;

        //For conversion
        public const int POUNDS_IN_STONES = 14;
        public const int INCH_IN_FEET = 12;

        //WHO Weight Status	
        public const double Underweight = 18.5;
        public const double Normal = 24.9;
        public const double Overweight = 29.9;
        public const double ObeseClassI = 34.9;
        public const double ObeseClassII = 39.9;
        public const double ObeseClassIII = 40.0
