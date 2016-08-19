using System;

// 14:00 - 14:20

namespace _14AprilEvening01Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int side = int.Parse(Console.ReadLine());
            int x = 0;
            int y = 0;
            string[] array = new string[5];

            int osnova = 3 * side;
            int kolona = 4 * side;

            for (int i = 0; i < 5; i++)
            {
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());

                if (x >= 0 && x <= osnova && y <= side && y >= 0)
                {
                    array[i] = "inside";
                }
                else if (x >= side && x <= side*2 && y >= 0 && y <= kolona)
                {
                    array[i] = "inside";
                }
                else
                {
                    array[i] = "outside";
                }
            }
            foreach (var output in array)
            {
                Console.WriteLine(output);
            }
        }
    }
}
