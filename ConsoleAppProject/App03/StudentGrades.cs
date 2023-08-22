using System;

using System.ComponentModel;

using System.ComponentModel.DataAnnotations;

using ConsoleAppProject.Helpers;



namespace ConsoleAppProject.App03

{

    /// <summary>

    /// At the moment this class just tests the

    /// Grades enumeration names and descriptions

    /// </summary>

    public class StudentGrades

    {

        // Constants(GradeBoundaries)



        public const int LowestMark = 0;

        public const int HighestMark = 100;

        public const int LowestGradeD = 40;

        public const int LowestGradeC = 50;

        public const int LowestGradeB = 60;

        public const int LowestGradeA = 70;




        public string[] Students { get; set; }

        public int[] Marks { get; set; }

        public int[] GradeProfile { get; set; }

        public double Mean { get; set; }

        public int Mininum { get; set; }

        public int Maximum { get; set; }

      

        public StudentGrades()

        {

            Students = new string[]

            {

            "JJ","Shegz","Adz","Dj","Montell","Jamarli","Tayeshaun","Kane","Alicia","Shan"



            };

            GradeProfile = new int[(int)Grades.A + 1];

            Marks = new int[Students.Length];



        }

        public void Run()

        {

            InputMarks();
            CalculateStats();
            CalculateGradeProfile();
            OutputMarks();

        }

        public void InputMarks()

        {

            for (int i = 0; i < Students.Length; i++)

            {

                Console.WriteLine($"Enter marks for {Students[i]}:");

                int marks = int.Parse(Console.ReadLine());

                Marks[i] = marks;



                // Update grade profile

                if (marks >= 90)

                {

                    GradeProfile[(int)Grades.A]++;

                }

                else if (marks >= 80)

                {

                    GradeProfile[(int)Grades.B]++;

                }

                else if (marks >= 70)

                {

                    GradeProfile[(int)Grades.C]++;

                }

                else if (marks >= 60)

                {

                    GradeProfile[(int)Grades.D]++;

                }

                else

                {

                    GradeProfile[(int)Grades.F]++;

                }

            }

        }
        public void start()
        {
            bool finished = false;
            while (!finished)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Input marks");
                Console.WriteLine("2. Output marks");
                Console.WriteLine("3. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        InputMarks();
                        break;
                    case "2":
                        OutputMarks();
                        break;
                    case "3":
                        finished = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }



        public void OutputMarks()
        {
            Console.WriteLine("Student Marks:");
            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine($"{Students[i]} - Marks: {Marks[i]} - Grade: {ConvertToGrade(Marks[i])}");
            }

            Console.WriteLine($"Mean Mark: {Mean}%");
            Console.WriteLine($"Minimum Mark: {Mininum}%");
            Console.WriteLine($"Maximum Mark: {Maximum}%");
            Console.WriteLine("Grade Profile:");
            Console.WriteLine($"A: {GradeProfile[(int)Grades.A]}");
            Console.WriteLine($"B: {GradeProfile[(int)Grades.B]}");
            Console.WriteLine($"C: {GradeProfile[(int)Grades.C]}");
            Console.WriteLine($"D: {GradeProfile[(int)Grades.D]}");
            Console.WriteLine($"F: {GradeProfile[(int)Grades.F]}");
        }


        public void CalculateStats()
        {
            double total = 0;
            Mininum = int.MaxValue; 
            Maximum = int.MinValue; 

            foreach (int mark in Marks)
            {
                total += mark;

                
                if (mark < Mininum)
                {
                    Mininum = mark;
                }
                if (mark > Maximum)
                {
                    Maximum = mark;
                }
            }

            Mean = total / Marks.Length;
        }





        public Grades ConvertToGrade(int mark)
        {
            if (mark >= LowestGradeA)
            {
                return Grades.A;
            }
            else if (mark >= LowestGradeB)
            {
                return Grades.B;
            }
            else if (mark >= LowestGradeC)
            {
                return Grades.C;
            }
            else if (mark >= LowestGradeD)
            {
                return Grades.D;
            }
            else
            {
                return Grades.F;
            }
        }

          
        



        public void CalculateGradeProfile()

        {

            for (int i = 0; i < GradeProfile.Length; i++)

            {

                GradeProfile[i] = 0;

            }



            foreach (int mark in Marks)



            {

                Grades grade = ConvertToGrade(mark);

                GradeProfile[(int)grade]++;

            }

        }

    }

}
