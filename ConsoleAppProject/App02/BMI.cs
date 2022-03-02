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


        /// <summary>
        /// Ouput Heading and Display menu choices
        /// User can select their preferred unit between Imperial and Mertic
        /// Then ouput the bmi category and bame message
        /// </summary>
        public void ConvertBmi()
        {
            ConsoleHelper.OutputHeading("Body Mass Index Calculator");
            Console.WriteLine("\nYour BMI, or Body Mass Index, is a measure of your weight compared to your height. \n" +
                "This app will use the body weight and height to calculate BMI Index\n" +
                "then classify the health risk based on the WHO weight status\n");
            SelectUnit("Please enter your choice > ");
            Console.WriteLine(OutputBmiCategory());
            Console.WriteLine(OutputBame());
        }


        /// <summary>
        /// Allows user to select their prefered unit 
        /// Imperial or Metric Unit
        /// </summary>
        private BMIUnit SelectUnit(string prompt)
        {
            string[] choices =
            {
                BMIUnit.Metric.ToString(),
                BMIUnit.Imperial.ToString()
            };
            int choiceNo = ConsoleHelper.SelectChoice(choices);
            return ExecuteChoice(choiceNo);
        }


         /// <summary>
        /// Execute other method 
        /// based on user's chosen unit
        /// returns the metric unit
        /// </summary>
        private BMIUnit ExecuteChoice(int choiceNo)
        {
            switch (choiceNo)
            {
                case 1:
                    InputMetricValue();
                    CalculateMetric();
                    return BMIUnit.Metric;
                case 2:
                    InputImperialValue();
                    CalculateImperial();
                    return BMIUnit.Imperial;
                default:
                    return BMIUnit.NoUnit;
            }
        }



