using System;

namespace ConsoleAppProject.App02
{
    public class BMI
    {
        private const double KG_IN_STONE = 6.35029;
        private const double FEET_IN_METRES = 0.3048;

        private double weight;
        private double height;
        private string weightUnit;
        private string heightUnit;

        public void Run()
        {
            OutputHeading();
            WeightMenu();
        }

        private void OutputHeading()
        {
            Console.WriteLine("\n =================================================");
            Console.WriteLine("    BMI calculator by Armstrong Lawal! ");
            Console.WriteLine(" =================================================\n");
            Console.WriteLine();
            Console.Write(@" Your BMI is a measure of your weight compared to your height this calculator will help you calculate you bmi , please note, if you are under ME, results may be inaccurate or 18 years of age, pregnant, a bodybuilder, or BAME.");

             
        }

        private void WeightMenu()
        {
            Console.WriteLine("  1. KG");
            Console.WriteLine("  2. Stone");
            Console.WriteLine("  3. Close");
            Console.Write(" Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    weightUnit = "KG";
                    heightUnit = "metres";
                    Console.Write("Enter weight in KG: ");
                    weight = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter height in metres: ");
                    height = Convert.ToDouble(Console.ReadLine());
                    double bmi = BMICalc();
                    DisplayBmiResult(bmi);
                    break;
                case 2:
                    weightUnit = "stone";
                    heightUnit = "feet";
                    Console.Write("Enter weight in stone: ");
                    weight = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter height in feet: ");
                    height = Convert.ToDouble(Console.ReadLine());
                    bmi = BMICalc();
                    DisplayBmiResult(bmi);
                    break;
                case 3:
                    Close();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter 1 - 3.");
                    break;
            }
        }

        private void Close()
        {
            int shutdown = 0;

            while (shutdown != 1 && shutdown != 2)
            {
                Console.WriteLine("Close application?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                Console.Write("Enter your choice: ");
                shutdown = Convert.ToInt32(Console.ReadLine());

                if (shutdown == 1)
                {
                    Console.WriteLine("Closing application...");
                    Environment.Exit(0);
                }
                else if (shutdown == 2)
                {
                    Console.WriteLine("Returning to main menu...");
                    Run();
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                }
            }
        }

        private double BMICalc()
        {
            double bmi = 0.0;

            if (weightUnit == "KG" && heightUnit == "metres")
            {
                bmi = weight / Math.Pow(height, 2);
            }
            else if (weightUnit == "stone" && heightUnit == "feet")
            {
                bmi = (weight * KG_IN_STONE) / Math.Pow(height * FEET_IN_METRES, 2);
            }
            else if (weightUnit == "KG" && heightUnit == "feet")
            {
                bmi = weight / Math.Pow(height * FEET_IN_METRES, 2);
            }
            else if (weightUnit == "stone" && heightUnit == "metres")
            {
                bmi = (weight * KG_IN_STONE) / Math.Pow(height, 2);
            }

            return bmi;
        }

        private void DisplayBmiResult(double bmi)
        {
            Console.WriteLine("Your BMI is: " + bmi);

            if (bmi < 16)
            {
                Console.WriteLine("You're severely underweight");
            }
            else if (bmi < 18.5)
            {
                Console.WriteLine("You're underweight");
            }
            else if (bmi < 25)
            {
                Console.WriteLine("You have normal weight");
            }
            else if (bmi < 30)
            {
                Console.WriteLine("You are overweight");
            }
            else if (bmi < 35)
            {
                Console.WriteLine("You are moderately obese");
            }
            else
            {
                Console.WriteLine("Your BMI increases your risk of a variety of medical conditions including type 2 diabetes, heart disease, and cancer.");
            }
        }


    }
}
