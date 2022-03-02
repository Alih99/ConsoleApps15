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
