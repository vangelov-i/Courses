using System;

namespace _06CalculatationsWithFac
{
    class CalculatationsWithFac
    {
        static void Main()
        {
            Console.Write("Please enter an integer number \"n\" bigger than 1: ");
            double n = double.Parse(Console.ReadLine());
            Console.Write("Please enter an integer number \"k\" where n > k > 1 : ");
            double k = double.Parse(Console.ReadLine());
            double nFac = 1;
            double kFac = 1;

            for (int i = 1; i <= n ; i++)
            {
                nFac *= i;
                if (i <= k)
                {
                    kFac *= i;
                }
            }
            Console.WriteLine("n! / k! = {0}", nFac / kFac);
        }
    }
}
