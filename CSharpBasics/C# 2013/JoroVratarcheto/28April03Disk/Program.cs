using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 100 tochki  za chas i polovina :/
namespace _28April03Disk
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());

            int firstRowsDots = (n - (r * 2 + 1)) / 2;
            int lastRowsDots = firstRowsDots + r * 2;
            int firstQuater = firstRowsDots + r / 2; 
            int lastQuater = firstRowsDots + r + r / 2;

            for (int i = 0; i < n; i++)
            {
                if (i < firstRowsDots || i > lastRowsDots)
                {
                    Console.Write(new string('.', n));
                }
                else if (i == firstRowsDots || i == lastRowsDots)
                {
                    Console.Write(new string('.', n / 2));
                    Console.Write("*");
                    Console.Write(new string('.', n / 2));
                }
                else if (i < n / 2)
                {
                    int starsUp = 1 + 2 * (int)Math.Sqrt(r * r - (n / 2 - i) * (n / 2 - i));
                    Console.Write(new string('.', (n - starsUp) / 2));
                    Console.Write(new string('*', starsUp));
                    Console.Write(new string('.', (n - starsUp) / 2));
                }
                else if (i == n / 2)
                {
                    Console.Write(new string('.', (n - (2 * r + 1)) / 2));
                    Console.Write(new string('*', 2 * r + 1));
                    Console.Write(new string('.', (n - (2 * r + 1)) / 2));
                }
                else if (i > n / 2)
                {
                    int starsDown = 1 + 2 * (int)Math.Sqrt(r * r - (i - n / 2) * (i - n / 2));
                    Console.Write(new string('.', ((n - starsDown) / 2)));
                    Console.Write(new string('*', starsDown));
                    Console.Write(new string('.', ((n - starsDown) / 2)));
                }
                Console.WriteLine();
            }
        }
    }
}
