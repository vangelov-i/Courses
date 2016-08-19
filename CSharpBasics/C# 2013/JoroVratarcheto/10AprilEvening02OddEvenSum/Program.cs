using System;

namespace _10AprilEvening02OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[2 * n];

            for (int i = 0; i < 2 * n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int oddSum = 0;
            int evenSum = 0;
            for (int i = 0; i < 2 * n; i++)
            {
                if (i % 2 == 0)
                {
                    oddSum += array[i];
                }
                else
                {
                    evenSum += array[i];
                }
            }

            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes, sum={0}", evenSum);
            }
            else
            {
                Console.WriteLine("No, diff={0}", Math.Abs(oddSum-evenSum));
            }
        }
    }
}
///17:13
