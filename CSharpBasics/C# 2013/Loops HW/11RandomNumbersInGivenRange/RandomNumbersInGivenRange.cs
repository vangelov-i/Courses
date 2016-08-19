using System;

namespace _11RandomNumbersInGivenRange
{
    class RandomNumbersInGivenRange
    {
        static void Main()
        {
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("min: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("max (where max > min): ");
            int max = int.Parse(Console.ReadLine());
            Random num = new Random();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(num.Next(min, max + 1));
            }
        }
    }
}
