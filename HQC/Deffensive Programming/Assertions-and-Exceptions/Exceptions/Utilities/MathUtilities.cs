namespace Exceptions_Homework.Utilities
{
    using System;

    public static class MathUtilities
    {
        public static bool CheckPrime(int number)
        {
            if (number < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(number), "Must be positive.");
            }

            bool isPrime = true;
            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }
    }
}