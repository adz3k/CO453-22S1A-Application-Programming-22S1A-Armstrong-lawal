using System;
using ConsoleAppProject.App01;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// Users can use this app to convert distances measured in one unit of measurement to another. It can, for example, convert a distance in miles to a similar distance in feet.
    /// <author>
    /// Armstrong Lawal
    /// </author>
    public class DistanceConverter
    {
      public const double FEET_IN_MILES = 5280;
      public const double METRES_IN_MILES = 1609.34;

      public const double FEET_IN_METRES = 3.28084;
      private double ToDistance;
      private double FromDistance;

      public string FromUnit;
        public string ToUnit;

       ///<summary>
       ///
       ///<summary>
  //sihanharoon@gmail.com

        public void Run()
        {
          //step 1 - Input
            Console.Write("Enter the FROM unit: \n");
            FromUnit = UnitMenu();
            Console.WriteLine("Enter the TO unit: \n");
            ToUnit = UnitMenu();

            FromDistance = InputDistance(FromUnit);

            /*FromUnit= "Miles";
            ToUnit = "feet";*/

            // step 2 - conversion process
            CalculateDistance();

            // step 3
            Print();
        }
        private void OutputHeading()
        {
            Console.WriteLine("\n =================================================");
            Console.WriteLine("    Distance by Armstrong Lawal! ");
            Console.WriteLine(" =================================================\n");
          
        }
        
      /// <summary>
      /// Prompt the user to enter the distance in miles
      /// Input the miles as a double number 
      ///</summary>
      
  
      private void InputMiles()
      {
       Console.WriteLine("Please enter the number of miles > ");
       string value = Console.ReadLine();
       FromDistance = Convert.ToDouble(value);
      }
      private void CalculateDistance()
      {
        if (FromUnit == "miles" && ToUnit == "feet")
        {
          ToDistance = FromDistance * FEET_IN_MILES;
        }
        else if (FromUnit == "feet" && ToUnit == "miles")
        {
          ToDistance = FromDistance / FEET_IN_MILES;
        }
        else if (FromUnit == "miles" && ToUnit == "metres")
        {
          ToDistance = FromDistance * METRES_IN_MILES;
        }
        else if (FromUnit == "feet" && ToUnit == "metres")
        {
          ToDistance = FromDistance / FEET_IN_METRES;
        }
        else if (FromUnit == "metres" && ToUnit == "feet")
        {
          ToDistance = FromDistance * FEET_IN_METRES;
        }
        else if (FromUnit == "metres" && ToUnit == "miles")
        {
          ToDistance = FromDistance / METRES_IN_MILES;
        }
        else if (FromUnit == ToUnit)
        {
          ToDistance = FromDistance;
        }
      }
        public double InputDistance(string prompt)
        {
            Console.WriteLine("You are converting " + FromUnit + " to " + ToUnit);
            Console.WriteLine("Please enter the number of " + prompt);
            return Convert.ToDouble(Console.ReadLine());
        }
      private void OutputFeet()
      {
       Console.WriteLine(FromDistance + " " + FromUnit + " is " + ToDistance + " " + ToUnit);
      }
   public string UnitMenu()
        {
            Console.WriteLine("1.Feet");
            Console.WriteLine("2. Miles");
            Console.WriteLine("3. Metres");
            Console.WriteLine("4. Close");

            Console.WriteLine("Enter");
            int choice;
            choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        return "Feet";
                    case 2:
                        return "Miles";
                    case 3:
                        return "metres";
                    case 4:
                        //Close();
                        break;
                }
                if (choice <= 0 || choice > 4)
                {
                    Console.WriteLine("Invalid choice. Please enter 1 - 4. \n");
                }
                else
                {
                    Console.WriteLine("Invalid Input. Please enter numbers 1 - 4");
                }
                        
            return null;         
        }
   
      private void Print() 
        {
            OutputHeading();
            Console.WriteLine(FromDistance + " " + FromUnit + " is " + ToDistance + " " + ToUnit);
           
        }
    }
}



