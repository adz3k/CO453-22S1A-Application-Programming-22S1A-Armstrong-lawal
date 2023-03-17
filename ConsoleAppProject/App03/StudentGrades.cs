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

 

        //Properties

        public string[] Students { get; set; }

        public int[] Marks { get; set; }

        public int[] GradeProfile { get; set; }

        public double Mean { get; set; }

        public int Mininum { get; set; }

        public int Maximum { get; set; }

        // Atrributes

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

 

        public void OutputMarks()

        {

            throw new NotImplementedException();

        }

        public Grades ConvertToGrade(int mark)

        {

            throw new NotImplementedException();

        }

        public void CalculateStats()

        {

            double total = 0;

            foreach (int mark in Marks)

                total += mark;

            Mean = total / Marks.Length;

        }

        public void ConvertToGrade()

        {

 

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
