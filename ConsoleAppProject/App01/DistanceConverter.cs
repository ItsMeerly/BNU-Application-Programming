using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This class offers methods for converting a given distance
    /// measured in miles to the equivalent distance measured in feet
    /// </summary>
    /// <author>
    /// Nathaniel Meer | Version: 0.1
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;
        private double miles;
        private double feet;
        /// <summary>
        /// 
        /// </summary>
        public void Run()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }
        /// <summary>
        /// Promt the user to enter the distance in miles
        /// Input the miles as a double number
        /// </summary>
        public void OutputHeading()
        {
            Console.WriteLine("\n =================================================");
            Console.WriteLine("               Convert Miles to Feet              ");
            Console.WriteLine("                 by Nathaniel Meer                ");
            Console.WriteLine(" =================================================\n");
        }
            private void InputMiles()
        {
            Console.Write("Please enter the number of Miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }
        /// <summary>
        /// Calculates the conversion of Miles to Feet
        /// </summary>
        private void CalculateFeet()
        {
            feet = miles * 5280;
        }
        /// <summary>
        /// Outputs the previously calculated conversion using concatonated strings
        /// Checks for one or multiple miles in order to ensure grammatical accuracy
        /// </summary>
        private void OutputFeet()
        {
            if (miles == 1)
            {
                Console.WriteLine(miles + " Mile is " + feet + " feet!");
            }
            else
            {
                Console.WriteLine(miles + " Miles is " + feet + " feet!");
            }
        }
    }
}
