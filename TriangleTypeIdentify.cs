using System;

namespace TriangleTypeIdentifier
{
    
    class TriangleTypeIdentifier
    {
        public string GetTriangleType(double side1, double side2, double side3)
        {
            if (side1 == side2 && side2 == side3)
            {
                return "a Equilateral triangle";
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                return "a Isosceles triangle";
            }
            else
            {
                return "a Scalene triangle";
            }
        }
    }

        class TriangleTypeIdentify
    {
        static void Main(string[] args)
        {
            TriangleTypeIdentifier triangleTypeIdentifier = new TriangleTypeIdentifier();
            Console.WriteLine("Triangle Type Identifier\n");

            try
            {
    
                Console.Write("Enter the length of the first side: ");
                double side1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the length of the second side: ");
                double side2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the length of the third side: ");
                double side3 = Convert.ToDouble(Console.ReadLine());

                
                string triangleType = triangleTypeIdentifier.GetTriangleType(side1, side2, side3);
                Console.WriteLine($"The triangle with sides {side1}, {side2}, and {side3} is {triangleType}.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input format. Please enter valid numerical values.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
