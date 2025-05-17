using System;
using PrimeFactorLib;

namespace PrimeFactorApp
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number (<=1000): ");
            if (int.TryParse(Console.ReadLine(), out int number) && number <= 1000)
            {
                Console.WriteLine($"Prime factors: {MathUtilities.PrimeFactors(number)}");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
