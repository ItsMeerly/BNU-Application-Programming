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
        private double miles;
        private double feet;
        /// <summary>
        /// 
        /// </summary>
        public void Run()
        {
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }
        /// <summary>
        /// Promt the user to enter the distance in miles
        /// Input the miles as a double number
        /// </summary>
        private void InputMiles()
        {
            Console.Write("Please enter the number of Miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }
        /// <summary>
        /// 
        /// </summary>
        private void CalculateFeet()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        private void OutputFeet()
        {

        }
    }
}
