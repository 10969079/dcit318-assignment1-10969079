using System;

namespace GradeCalculator
{
        class GradeCalculator
    {
        public string GetLetterGrade(double numericalGrade)
        {
            if (numericalGrade >= 90)
            {
                return "A";
            }
            else if (numericalGrade >= 80)
            {
                return "B";
            }
            else if (numericalGrade >= 70)
            {
                return "C";
            }
            else if (numericalGrade >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }

    
    class GradeCalc
    {
        static void Main(string[] args)
        {
            GradeCalculator gradeCalculator = new GradeCalculator();
            Console.WriteLine("Grade Calculator\n");

            try
            {
                // Input: Get numerical grade
                Console.Write("Enter a numerical grade between 0 and 100: ");
                double numericalGrade = Convert.ToDouble(Console.ReadLine());

                // Validate the input grade
                if (numericalGrade < 0 || numericalGrade > 100)
                {
                    Console.WriteLine("Error: Grade must be between 0 and 100.");
                }
                else
                {
                    // Get the letter grade
                    string letterGrade = gradeCalculator.GetLetterGrade(numericalGrade);
                    Console.WriteLine($"The letter grade for {numericalGrade} is {letterGrade}.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input format. Please enter a numerical grade.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
