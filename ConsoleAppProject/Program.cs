using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Nathaniel Meer 05/02/2022
    /// </summary>
    public static class Program
    {
        public const string AppChoice = "1";
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("   BNU CO453 Applications Programming 2021-2022!  ");
            Console.WriteLine("                   by Nate Meer                   ");
            Console.WriteLine(" =================================================\n");

            Console.WriteLine("Which application would you like to run?");
            Console.WriteLine("App01: Distance Converter");
            Console.WriteLine("App02: BMI Calculator\n");
            string AppChoice = Console.ReadLine();


            if (AppChoice == "2")
            {
                BMI calculator = new BMI();
                calculator.Run();
            }


            else if (AppChoice == "1")
            {
                DistanceConverter converter = new DistanceConverter();
                converter.DistanceConversion();
            }

            else
                Console.WriteLine("Invalid input, please run again!");



        }
    }
}
