using System;

namespace TicketPriceCalculator
{
    
    class TicketPriceCalculator
    {
        public double GetTicketPrice(int age)
        {
            const double regularPrice = 10.0;
            const double discountedPrice = 7.0;

            if (age <= 12 || age >= 65)
            {
                return regularPrice-discountedPrice;
            }
            else
            {
                return regularPrice;
            }
        }
    }

        class TicketPriceCalc
    {
        static void Main(string[] args)
        {
            TicketPriceCalculator ticketPriceCalculator = new TicketPriceCalculator();
            Console.WriteLine("Ticket Price Calculator\n");

            try
            {
                
                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                
                double ticketPrice = ticketPriceCalculator.GetTicketPrice(age);
                Console.WriteLine($"The ticket price for age {age} is GHC{ticketPrice}.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input format. Please enter a valid age.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
