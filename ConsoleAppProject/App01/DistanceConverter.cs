using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This class offers methods for converting a given distance
    /// measured in miles to the equivalent distance measured in feet
    /// </summary>
    /// <author>
    /// Nathaniel Meer | Version: 0.8
    /// </author>
    public class DistanceConverter
    {
        /// <summary>
        /// Distance Conversion Constants
        /// </summary>
        public const int FEET_IN_MILES = 5280;
        public const int FEET_IN_YARDS = 3;
        public const double FEET_IN_METRES = 3.28;
        public const double FEET_IN_KILOMETERS = FEET_IN_METRES * 1000;
        public const double METRES_IN_MILES = 1609.34;
        public const int METRES_IN_KILOMETERS = 1000;
        public const int YARDS_IN_MILES = FEET_IN_MILES / FEET_IN_YARDS;
        public const double YARDS_IN_METRES = FEET_IN_METRES / FEET_IN_YARDS;
        public const double YARDS_IN_KILOMETERS = YARDS_IN_METRES * 1000;
        public const double CENTIMETERS_IN_FEET = 30.48;
        public const int CENTIMETERS_IN_METRES = 100;
        public const int CENTIMETERS_IN_KILOMETERS = CENTIMETERS_IN_METRES * 1000;
        public const double CENTIMETERS_IN_YARDS = CENTIMETERS_IN_FEET / FEET_IN_YARDS;
        public const double CENTIMETERS_IN_MILES = CENTIMETERS_IN_METRES * METRES_IN_MILES;
        public const double KILOMETERS_IN_MILES = METRES_IN_MILES / 1000;

        /// <summary>
        /// Distance Unit Names
        /// </summary>
        public const string miles = "MILES";
        public const string feet = "FEET";
        public const string yards = "YARDS";
        public const string centimeters = "CENTIMETERS";
        public const string metres = "METRES";
        public const string kilometers = "KILOMETERS";

        /// <summary>
        /// Variables which control the input and output of the conversion
        /// </summary>
        private double startDistance;
        private double endDistance;

        /// <summary>
        /// Variables which control the units being converted
        /// </summary>
        private string startUnit;
        private string endUnit;

        /// <summary>
        /// "DistanceConversion" method starts the program and spits out necessary UI text
        /// </summary>
        public void DistanceConversion()
        {
            startUnit = SelectUnit("Please choose between 1-6 > ");
            endUnit = SelectUnit("Please choose between 1-6 > ");

            OutputHeading($"Converting {startUnit} to {endUnit}");
            startDistance = InputDistance($"Please input the number of {startUnit} you would like to convert > ");

            CalculateDistance();
            OutputDistance();
        }

        /// <summary>
        /// This method contains the Unit Conversion formulas
        /// </summary>
        private void CalculateDistance()
        {
            /// Miles to Feet | Feet to Miles
            if (startUnit == miles && endUnit == feet)
            {
                endDistance = startDistance * FEET_IN_MILES;
            }
            else if (startUnit == feet && endUnit == miles)
            {
                endDistance = startDistance / FEET_IN_MILES;
            }

            /// Metres to Miles | Miles to Metres
            else if (startUnit == metres && endUnit == miles)
            {
                endDistance = startDistance / METRES_IN_MILES;
            }
            else if (startUnit == miles && endUnit == metres)
            {
                endDistance = startDistance * METRES_IN_MILES;
            }

            /// Feet to Metres | Metres to feet
            else if (startUnit == feet && endUnit == metres)
            {
                endDistance = startDistance / FEET_IN_METRES;
            }
            else if (startUnit == metres && endUnit == feet)
            {
                endDistance = startDistance * FEET_IN_METRES;
            }

            /// Feet to Kilometers | Kilometers to feet
            else if (startUnit == feet && endUnit == kilometers)
            {
                endDistance = startDistance * FEET_IN_KILOMETERS;
            }
            else if (startUnit == kilometers && endUnit == feet)
            {
                endDistance = startDistance / FEET_IN_KILOMETERS;
            }

            /// Feet to Yards | Yards to feet
            else if (startUnit == feet && endUnit == yards)
            {
                endDistance = startDistance * FEET_IN_YARDS;
            }
            else if (startUnit == yards && endUnit == feet)
            {
                endDistance = startDistance / FEET_IN_YARDS;
            }

            /// Centimeters to Feet | Feet to Centimeters
            else if (startUnit == centimeters && endUnit == feet)
            {
                endDistance = startDistance / CENTIMETERS_IN_FEET;
            }
            else if (startUnit == feet && endUnit == centimeters)
            {
                endDistance = startDistance * CENTIMETERS_IN_FEET;
            }

            /// Centimeters to Yards | Yards to Centimeters
            else if (startUnit == centimeters && endUnit == yards)
            {
                endDistance = startDistance / CENTIMETERS_IN_YARDS;
            }
            else if (startUnit == yards && endUnit == centimeters)
            {
                endDistance = startDistance * CENTIMETERS_IN_YARDS;
            }

            /// Metres to Yards | Yards to Metres
            else if (startUnit == metres && endUnit == yards)
            {
                endDistance = startDistance * YARDS_IN_METRES;
            }
            else if (startUnit == yards && endUnit == metres)
            {
                endDistance = startDistance / YARDS_IN_METRES;
            }

            /// Kilometers to Yards | Yards to Kilometers
            else if (startUnit == kilometers && endUnit == yards)
            {
                endDistance = startDistance * YARDS_IN_KILOMETERS;
            }
            else if (startUnit == yards && endUnit == kilometers)
            {
                endDistance = startDistance / YARDS_IN_KILOMETERS;
            }

            /// Miles to Yards | Yards to Miles
            else if (startUnit == miles && endUnit == yards)
            {
                endDistance = startDistance * YARDS_IN_MILES;
            }
            else if (startUnit == yards && endUnit == miles)
            {
                endDistance = startDistance / YARDS_IN_MILES;
            }

            /// Metres to Centimeters | Centimeters to Metres
            else if (startUnit == metres && endUnit == centimeters)
            {
                endDistance = startDistance * CENTIMETERS_IN_METRES;
            }
            else if (startUnit == centimeters && endUnit == metres)
            {
                endDistance = startDistance / CENTIMETERS_IN_METRES;
            }

            /// Metres to Kilometers | Kilometers to Metres
            else if (startUnit == metres && endUnit == kilometers)
            {
                endDistance = startDistance * METRES_IN_KILOMETERS;
            }
            else if (startUnit == kilometers && endUnit == metres)
            {
                endDistance = startDistance / METRES_IN_KILOMETERS;
            }

            /// Kilometers to Centimeters | Centimeters to Kilometers
            else if (startUnit == kilometers && endUnit == centimeters)
            {
                endDistance = startDistance * CENTIMETERS_IN_KILOMETERS;
            }
            else if (startUnit == centimeters && endUnit == kilometers)
            {
                endDistance = startDistance / CENTIMETERS_IN_KILOMETERS;
            }

            /// Miles to Centimeters | Centimeters to Miles
            else if (startUnit == miles && endUnit == centimeters)
            {
                endDistance = startDistance * CENTIMETERS_IN_MILES;
            }
            else if (startUnit == centimeters && endUnit == miles)
            {
                endDistance = startDistance / CENTIMETERS_IN_MILES;
            }

            /// Miles to Yards | Yards to Miles
            else if (startUnit == miles && endUnit == yards)
            {
                endDistance = startDistance * YARDS_IN_MILES;
            }
            else if (startUnit == yards && endUnit == miles)
            {
                endDistance = startDistance / YARDS_IN_MILES;
            }

            /// Miles to Kilometers | Kilometers to Miles
            else if (startUnit == miles && endUnit == kilometers)
            {
                endDistance = startDistance * KILOMETERS_IN_MILES;
            }
            else if (startUnit == kilometers && endUnit == miles)
            {
                endDistance = startDistance / KILOMETERS_IN_MILES;
            }
        }


        /// <summary>
        /// This prompts the user with the unit selection and executes the choice chosen by the user
        /// </summary>
        private string SelectUnit(string prompt)
        {
            string choice = DisplaySelection(prompt);
            return ExecuteChoice(choice);
        }

        /// <summary>
        /// Promt the user to enter the unit of measurement they
        /// wish to convert from
        /// </summary>
        private static string ExecuteChoice(string choice)
        {
            if (choice == "1")
            {
                return miles;
            }
            else if (choice == "2")
            {
                return feet;
            }
            else if (choice == "3")
            {
                return yards;
            }
            else if (choice == "4")
            {
                return centimeters;
            }
            else if (choice == "5")
            {
                return metres;
            }
            else if (choice == "6")
            {
                return kilometers;
            }
            else
            {
                Console.WriteLine("That is an invalid input, please try again! ");
                return null;
            }
            //Console.WriteLine($" You have selected {unit}");
            //Console.WriteLine();

        }

        /// <summary>
        /// This displays the options of units you can choose for conversion
        /// </summary>

        private static string DisplaySelection(string prompt)
        {
            Console.WriteLine("\nPlease select a unit of distance: \n");
            Console.WriteLine($"1. {miles}");
            Console.WriteLine($"2. {feet}");
            Console.WriteLine($"3. {yards}");
            Console.WriteLine($"4. {centimeters}");
            Console.WriteLine($"5. {metres}");
            Console.WriteLine($"6. {kilometers}\n");

            Console.Write("Please choose between 1-6 > ");
            string choice = Console.ReadLine();
            return choice;
        }

        /// <summary>
        /// This accepts an input and converts it to Double in order to be easily used within the program
        /// </summary>
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        /// <summary>
        /// This outputs the conversion
        /// </summary>
        private void OutputDistance()
        {
            Console.WriteLine($"{startDistance} {startUnit} is {endDistance} {endUnit}! ");

        }


        /// <summary>
        /// Displays a header describing the function of the program
        /// and the author of the code, as well as outputting the conversion parameters
        /// </summary>
        public void OutputHeading(string prompt)
        {
            Console.WriteLine("\n =================================================");
            Console.WriteLine("                 Distance Converter               ");
            Console.WriteLine("                    by Nate Meer                  ");
            Console.WriteLine(" =================================================\n");

            Console.WriteLine(prompt);
            Console.WriteLine();
        }
    }
}