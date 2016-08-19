using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//12:55 - 13:20 ->  100
class Program
{
    static void Main(string[] args)
    {
        checked
        {
            int n = int.Parse(Console.ReadLine());

            int width = n * 3;
            int height = (3 * n / 2 - 1);
            int roofHeight = n / 2;
            int wheelsHeight = n / 2 - 1;
            int upper = n - 1;
            int betweenWheels = n - 2;
            int wheelInside = (width - roofHeight * 2 - 4 - betweenWheels) / 2;

            for (int i = 0; i < height; i++)
            {
                if (i == 0)
                {
                    Console.Write(new string('.', n));
                    Console.Write(new string('*', n));
                    Console.Write(new string('.', n));
                }
                else if (i < roofHeight)
                {
                    Console.Write(new string('.', upper));
                    Console.Write("*");
                    Console.Write(new string('.', width - upper * 2 - 2));
                    Console.Write("*");
                    Console.Write(new string('.', upper));
                    upper--;
                }
                else if (i == n / 2)
                {
                    upper++;
                    Console.Write(new string('*', upper));
                    Console.Write(new string('.', width - upper * 2));
                    Console.Write(new string('*', upper));
                }
                else if (i < n - 1)
                {
                    Console.Write("*");
                    Console.Write(new string('.', width - 2));
                    Console.Write("*");
                }
                else if (i == n - 1)
                {
                    Console.Write(new string('*', width));
                }
                else if (i == height - 1)
                {
                    Console.Write(new string('.', roofHeight));
                    Console.Write(new string('*', wheelInside + 2));
                    Console.Write(new string('.', betweenWheels));
                    Console.Write(new string('*', wheelInside + 2));
                    Console.Write(new string('.', roofHeight));
                }
                else
                {
                    Console.Write(new string('.', roofHeight));
                    Console.Write("*");
                    Console.Write(new string('.', wheelInside));
                    Console.Write("*");
                    Console.Write(new string('.', betweenWheels));
                    Console.Write("*");
                    Console.Write(new string('.', wheelInside));
                    Console.Write("*");
                    Console.Write(new string('.', roofHeight));
                }
                Console.WriteLine();
            }



        }
    }
}
