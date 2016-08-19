using System;
using System.Linq;

namespace _12AprilMorning02Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            string strInput = Console.ReadLine();
            string[] array = strInput.Split(' ');

            int[] numbers = new int[array.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(array[i]);
            }

            int[] sums = new int[numbers.Length / 2];
            for (int i = 0, j = 0; i < numbers.Length; i += 2, j++)
            {
                sums[j] = numbers[i] + numbers[i + 1];
            }

            int maxDiff = 0;
            for (int i = 1; i < sums.Length; i++)
            {
                int diff = Math.Abs(sums[i] - sums[i-1]);
                maxDiff = Math.Max(diff, maxDiff);
            }

            if (sums.Min() == sums.Max())
            {
                Console.WriteLine("Yes, value={0}", sums[0]);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", maxDiff); 
                // zashto tozi red ne raboti s "Math.Abs(sums.Max() - sums.Min())" vmesto "maxDiff"
            }
        }
    }
}
//11:30 - 12:00