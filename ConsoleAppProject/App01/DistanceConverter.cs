using System;

namespace ConsoleAppProject.App01
{
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;

        public const string FEET = "Feet";
        public const string METRES = "Metres";
        public const string MILES = "Miles";

        private double fromDistance;
        private double toDistance;

        private string fromUnit;
        private string toUnit;

        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }

        public void ConvertDistance()
        {
            fromUnit = SelectUnit("Please select the from distance unit:\n 1. Feet\n 2. Metres\n 3. Miles\n > ");
            toUnit = SelectUnit("Please select the to distance unit:\n 1. Feet\n 2. Metres\n 3. Miles\n > ");

            OutputHeading($"Converting {fromUnit} to {toUnit}");

            fromDistance = InputDistance($"Please enter the number of {fromUnit} > ");

            CalculateDistance();

            OutputDistance();
        }

        public void CalculateDistance()
        {
            if (fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
            else if (fromUnit == MILES && toUnit == METRES)
            {
                toDistance = fromDistance * METRES_IN_MILES;
            }
            else if (fromUnit == METRES && toUnit == MILES)
            {
                toDistance = fromDistance / METRES_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == METRES)
            {
                toDistance = fromDistance / FEET_IN_MILES * METRES_IN_MILES;
            }
            else if (fromUnit == METRES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES / METRES_IN_MILES;
            }
            else
            {
                toDistance = fromDistance;
            }
        }

        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoice(prompt);
            return ExecuteChoice(choice);
        }

        private string ExecuteChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    return FEET;
                case "2":
                    return METRES;
                case "3":
                    return MILES;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                    return ExecuteChoice(DisplayChoice(""));
            }
        }

        private static string DisplayChoice(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        private void OutputDistance()
        {
            Console.WriteLine($" {fromDistance} {fromUnit} is {toDistance} {toUnit}!");
        }

        private void OutputHeading(string prompt)
        {
            Console.WriteLine("\n =================================================");
            Console.WriteLine("    Distance Converter by Armstrong Lawal! ");
            Console.WriteLine(" =================================================\n");
            Console.WriteLine(prompt);
            Console.WriteLine();
        }
    }
}
