using System;
using System.Linq;

namespace _12RandomizeNumbers1ToN
{
    class RandomizeNumbers1ToN
    {
        static void Main()
        {
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = i + 1;
            }

            Random num = new Random();
            int randomNumber = 0;
            int randomIndex = 0;
            for (int i = 1; i <= n; i++)
            {
                randomIndex = num.Next(0, (n - i) + 1); //1 is like a "magic" number here?
                randomNumber = array[randomIndex];
                Console.WriteLine("{0}", randomNumber);
                array = array.Where(val => val != randomNumber).ToArray();
            }
        }
    }
}
