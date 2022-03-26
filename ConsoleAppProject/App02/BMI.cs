using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This project will calculate the BMI from Imperial or Metric values
    /// </summary>
    /// <author>
    /// Nathaniel Meer version 0.4
    /// </author>

    public class BMI
    {

        /// <summary>
        /// These are the public constants that the program relies on in order to function correctly.
        /// </summary>
        public const float kg = 0;
        public const float lb = 0;
        public const float metre = 0;
        public const float inch = 0;
        public const float bmi = 0;
        public string choice = "";

        /// <summary>
        /// Run is called by Program.cs in order to start App02
        /// </summary>
        public void Run()
        {
            DisplayType(choice);
        }

        /// <summary>
        /// Displays the unit types and requests the user to input a choice
        /// </summary>
        public void DisplayType(string choice)
        {
            Console.WriteLine("\nPlease select unit type: \n");
            Console.WriteLine($"1. Metric");
            Console.WriteLine($"2. Imperial\n");

            Console.Write("Please choose between 1 and 2 > ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                MetricConversion();
            }
            else if (choice == "2")
            {
                ImperialConversion();
            }
            else if (choice != "1" || choice != "2")
            {
                Console.WriteLine("That is an invalid input, please try again!");
                DisplayType(choice);
            }
        }

        //public string TypeChoice(string choice)

        /// <summary>
        /// Requests Input for metric units and calculates the BMI
        /// </summary>
        private void MetricConversion()
        {
            Console.WriteLine("Please input your weight in Kilograms: ");
            float kg = float.Parse(Console.ReadLine());
            Console.WriteLine("Please input your height in Metres: ");
            float metre = float.Parse(Console.ReadLine());
            float bmi = kg / (metre * metre);
            BMIChecker(bmi, choice);
        }

        /// <summary>
        /// Requests Input for imperial units and calculates the BMI
        /// </summary>
        private void ImperialConversion()
        {
            Console.WriteLine("Please input your weight in Pounds: ");
            float lb = float.Parse(Console.ReadLine());
            Console.WriteLine("Please input your height in Inches: ");
            float inch = float.Parse(Console.ReadLine());
            float bmi = lb * 703 / (inch * inch);
            BMIChecker(bmi, choice);
        }

        /// <summary>
        /// Calculates the category of weight for BAME from the WHO BMI Chart
        /// </summary>
        private void BMIChecker(float bmi, string choice)
        {
        if (bmi >= 0)
            {
                Console.WriteLine("");
                if (bmi < 18.5)
                    Console.WriteLine("You are underweight for WHO standards, I would advise gaining weight to be healthy.");
                else if (bmi >= 18.5 && bmi < 25)
                    Console.WriteLine("You are a healthy weight by the WHO standards. Keep up the healthy lifestyle.");
                else if (bmi >= 25 && bmi < 30)
                    Console.WriteLine("You are overweight by the WHO standards. I would advise regular exercise and a healthy diet.");
                else if (bmi >= 30 && bmi < 35)
                    Console.WriteLine("By WHO standards, your BMI is judged as Obese Class 1. I would advise losing weight and starting to implement an exercise regime.");
                else if (bmi >= 35 && bmi < 40)
                    Console.WriteLine("By WHO standards, your BMI is judged as Obese Class 2. I would advise losing weight and to speak with your doctor.");
                else if (bmi >= 40)
                    Console.WriteLine("By WHO standards, your BMI is judged as Obese Class 3. I would advise speaking with your doctor urgently if you haven't already.");

                Console.WriteLine("\nYour BMI is " + bmi);
                if (bmi >= 23 && bmi < 27.5)
                    Console.WriteLine("\nAnd if you are a part of the BAME community, \nyou may have an increased risk of developing some long-term chronic conditions such as type 2 diabetes.");
                if (bmi >= 27.5)
                    Console.WriteLine("\nAnd if you are a part of the BAME community, \nyou may have a much higher risk of developing some long-term chronic conditions such as type 2 diabetes.");

            }
        /// If Choice doesn't equal either 1 or 2 then the program is reset at the point of input conversion
        else
            Console.WriteLine("You have inputted incorrect values, please try again! \n");
            if (choice == "1")
                MetricConversion();
            else if (choice == "2")
                ImperialConversion();
            

        }
    }
}
