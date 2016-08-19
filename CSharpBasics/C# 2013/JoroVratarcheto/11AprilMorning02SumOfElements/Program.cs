using System;
using System.Linq;

namespace _11AprilMorning02SumOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] array = input.Split(' ');
            long[] numbers = new long[array.Length];
            int counter = 0;
            foreach (var item in array)
            {
                numbers[counter] = long.Parse(item);
                counter++;
            }
            long max = numbers.Max();
            long sum = 0;
            bool isYes = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == (sum - numbers[i]))
                {
                    Console.WriteLine("Yes, sum={0}", numbers[i]);
                    isYes = true;
                    break;
                }

            }
            if (isYes == false)
            {
                Console.WriteLine("No, diff={0}", Math.Abs(sum - 2*max));
            }
        }
    }
}
//18:15
