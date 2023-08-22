using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
using System;

namespace ConsoleAppProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2022-2023! by armstrong lawal");
            Console.WriteLine(" =================================================");
            Console.WriteLine();

            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Distance Converter");
            Console.WriteLine("2. BMI Calculator");
            Console.WriteLine("3. Student Grades");
            Console.WriteLine("4. Social Media");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Run Distance Converter
                    DistanceConverter converter = new DistanceConverter();
                    converter.ConvertDistance();
                    break;
                case 2:
                    // Run BMI Calculator
                    BMI bmiCalculator = new BMI();
                    bmiCalculator.Run();
                    break;
                case 3:
                    // Run Student Grades
                    StudentGrades studentGrades = new StudentGrades();
                    studentGrades.Run();
                    break;
                case 4:
                    // Run Social Media
                    PostUI socialMedia = new PostUI();
                    socialMedia.Run();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select 1, 2, 3, or 4.");
                    break;


            }
        }
    }

}
            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2022-2023! ");
            Console.WriteLine("                     Armstrong Lawal                 ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();

            DistanceConverter converter = new DistanceConverter();
            BMICalculator body = new BMICalculator();
            StudentGrades grades = new StudentGrades();
            PostUI social = new PostUI();

            Console.WriteLine(@"Please select application:
            1. Distance Converter
            2. BMI Calculator
            3. Student Grades
            4. Social Space");
            int selection;
            selection = Convert.ToInt32(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    converter.Run();
                    break;
                case 2:
                    body.Run();
                    break;
                case 3:
                    grades.Run();
                    break;
                case 4:
                    social.Run();
                    break;
            }
            if (selection < 1 || selection > 4)
            {
                Console.WriteLine("Invalid selection, please enter 1 or 4");
                Program.Main(args);
                Console.WriteLine(@"Please select application:
                1. Distance Converter
                2. BMI Calculator
                3. Grade Calculator
                4. Social Space");
            }
            
        }
    }
}
