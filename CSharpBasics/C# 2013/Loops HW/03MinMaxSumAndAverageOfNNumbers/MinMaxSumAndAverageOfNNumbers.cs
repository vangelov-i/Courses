using System;
using System.Linq;

namespace _03MinMaxSumAndAverageOfNNumbers
{
    class MinMaxSumAndAverageOfNNumbers
    {
        static void Main()
        {
            Console.Write("Please enter how many numbers you will enter: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Please enter you numbers by pressing \"ENTER\" after each of them:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int min = array.Min();
            int max = array.Max();
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += array[i];
            }

            double avg = (double)sum / (double)n;
            Console.WriteLine("min = {0}", min);
            Console.WriteLine("max = {0}", max);
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("avg = {0:F2}", avg);



        }
    }
}
