using System;
using ConsoleAppProject.App01;
using System.ComponentModel.DataAnnotations;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This App calculates BMI weight in different units and helps inform users of there weight class and what stages they are on the bmi scale
    /// </summary>
    /// <author>
    /// Armstrong Lawal 0.1
    /// </author>
    
    private void OutputHeading()
        {
            Console.WriteLine("\n =================================================");
            Console.WriteLine("    BMI calculator by Armstrong Lawal! ");
            Console.WriteLine(" =================================================\n");
            Console.WriteLine();
            Console.Write(@"Please note, if you under 18 years of 
age, are pregnant, a body builder or BAME, results may be 
inaccurate.");
       
            }
    public class BMI
    {
        private const double KG_IN_STONE = 6.35029;
        private const double FEET_IN_METRES = 0.3048;

        private double weight;
        private double height;
        private string weightUnit;
        private string heightUnit;

        public void Run(){
            WeightMenu();
        }
        public string WeightMenu()
{
    Console.WriteLine("1. KG");
    Console.WriteLine("2. Stone");
    Console.WriteLine("3. Close");
    Console.WriteLine("Enter");

    int choice;
    choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            weightUnit = "KG";
            heightUnit = "metres";
            Console.WriteLine("Enter weight in KG:");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter height in metres:");
            height = Convert.ToDouble(Console.ReadLine());
            double bmi = BMICalc();
            Console.WriteLine("Your BMI is: " + bmi);
            break;
        case 2:
            weightUnit = "stone";
            heightUnit = "feet";
            Console.WriteLine("Enter weight in stone:");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter height in feet:");
            height = Convert.ToDouble(Console.ReadLine());
            break;
        case 3:
            Close();
            break;
    }

    if (choice <= 0 || choice > 3)
    {
        Console.WriteLine("Invalid choice. Please enter 1 - 3. \n");
    }

    return null;
}

        public void Close(){

        }
        public string HeightMenu()
        {
            Console.WriteLine("1. Metres");
            Console.WriteLine("2. Feet");
            Console.WriteLine("Enter");
            int choice;
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    return "metres";
                case 2:
                    return "feet";
            }
            if (choice <= 0 || choice > 2)
            {
                Console.WriteLine("Invalid choice. Please enter 1 - 2. \n");
            }
            return null;
        }
        
        public void DisplayBmiResult(double bmi){
            Console.WriteLine("Your BMI is: " + bmi);
        }
        public double BMICalc()
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


        public void InputData(){
            Console.WriteLine("Enter your weight (kg): ");
            double kg = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your height (m): ");
            double height = Convert.ToDouble(Console.ReadLine());
         
         double BMI = kg / (height * height);
         Console.WriteLine("Your Bmi is: " + BMI);
         Console.ReadKey();

         if (BMI < 16){
            Console.WriteLine("You're severly underweight");
         }
         else if (BMI < 18.5) {
            Console.WriteLine("You're underweight");
         }
         else if (BMI < 25){
            Console.WriteLine ("You have normal weight");
         }
         else if (BMI < 30){
            Console.WriteLine ("You are overweight");
         }
          else if (BMI < 35){
            Console.WriteLine ("You are moderately obese");
          }
         else{
            Console.WriteLine (" increases your risk of a variety of medical conditions including type 2 diabetes, heart disease and cancer.");
         } 
        
        }
      
    }
    private void Close()
{
    int shutdown = 0;

    while (shutdown != 1 && shutdown != 2)
    {
        Console.WriteLine("Close application? \n" + "1.Yes \n" + "2.No");
        shutdown = Convert.ToInt32(Console.ReadLine());

        if (shutdown == 1)
        {
            Console.WriteLine("Closing application...");
            System.Environment.Exit(0);
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
}
