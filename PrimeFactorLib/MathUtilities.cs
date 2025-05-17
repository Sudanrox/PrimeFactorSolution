using System;
using System.Collections.Generic;

namespace PrimeFactorLib
{
    public class MathUtilities
    {
        // This method returns the prime factors of a given number as a formatted string.
        public static string PrimeFactors(int number)
        {
            // Numbers less than 2 don't have prime factors
            if (number < 2)
                return "No prime factors";

            // List to store the prime factors
            List<int> factors = new List<int>();

            // Start dividing from the smallest prime number
            int divisor = 2;

            // Keep dividing the number by the current divisor
            while (number > 1)
            {
                // If divisible, it's a prime factor
                if (number % divisor == 0)
                {
                    factors.Add(divisor); // Add to the list
                    number /= divisor;    // Divide and continue
                }
                else
                {
                    // Move to the next possible divisor
                    divisor++;
                }
            }

            // Join the factors with 'x' for display, e.g., "2 x 2 x 5"
            return string.Join(" x ", factors);
        }
    }
}
