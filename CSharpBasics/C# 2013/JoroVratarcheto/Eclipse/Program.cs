using System;

namespace Eclipse
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string upperBottom = ' ' + new string('*', 2 * n - 2) + ' ';
            string inBetween = new string(' ', n - 1);
            string inside = '*' + new string('/', 2 * n - 2) + '*';
            string bridge = new string('-', n - 1);

            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == n - 1)
                {
                    Console.WriteLine(upperBottom + inBetween + upperBottom);
                }
                else if (i == n / 2)
                {
                    Console.WriteLine(inside + bridge + inside);
                }
                else
                {
                    Console.WriteLine(inside + inBetween + inside);
                }
            }
        }
    }
}
