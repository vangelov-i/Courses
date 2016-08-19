using System;

namespace _07CalculateN_K_N_K_
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please enter an integer number \"n\" where 1 < n < 100 : ");
            double n = double.Parse(Console.ReadLine());
            Console.Write("Please enter an integer number \"k\" where 1 < k < n : ");
            double k = double.Parse(Console.ReadLine());
            double difference = n-k;
            double nFac = 1;
            double kFac = 1;
            double diffFac = 1;

            for (int i = 1; i <= n; i++)
            {
                nFac *= i;
                if (i <= k)
                {
                    kFac *= i;
                }
                if (i <= difference)
                {
                    diffFac *= i;
                }
            }
            double combinations = nFac / (kFac * diffFac);
            Console.WriteLine("The number of possible combinations with {0} members and {1} elements is {2}", k,n,combinations);

        }
    }
}
