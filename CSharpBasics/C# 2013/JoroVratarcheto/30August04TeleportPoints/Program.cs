using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 
class Program
{
    static void Main(string[] args)
    {
        checked
        {

            string[] A = Console.ReadLine().Split(' ');
            string[] B = Console.ReadLine().Split(' ');
            string[] C = Console.ReadLine().Split(' ');
            string[] D = Console.ReadLine().Split(' ');
            decimal radius = decimal.Parse(Console.ReadLine());
            decimal step = decimal.Parse(Console.ReadLine());


            decimal height = decimal.Parse(D[1]) - decimal.Parse(A[1]);
            decimal width = decimal.Parse(B[0]) - decimal.Parse(A[0]);
            decimal wallX = decimal.Parse(B[0]) / 2.0m;
            decimal wallY = decimal.Parse(D[1]) / 2.0m;

            decimal aX = decimal.Parse(A[0]);
            decimal aY = decimal.Parse(A[1]);
            decimal bX = decimal.Parse(B[0]);
            decimal bY = decimal.Parse(B[1]);
            decimal cX = decimal.Parse(C[0]);
            decimal cY = decimal.Parse(C[1]);
            decimal dX = decimal.Parse(D[0]);
            decimal dY = decimal.Parse(D[1]);

            //decimal upLimit = Math.Min(radius, dY);
            //decimal downLimit = Math.Min(radius, aY);
            //decimal leftLimit = Math.
            //decimal tempPoint = 0m;

            decimal y = 0;
            decimal x = 0;
            decimal count = 0m;
            bool inside = x * x + y * y <= radius * radius;
            //bool inside = (Math.Pow((double)x - 0, 2) + Math.Pow((double)y - 0, 2)) <= Math.Pow((double)radius, 2);

            while (x <= radius)
            {
                while (y <= radius)
                {
                    if ((x > aX && x < bX) && (y < cY && y > bY) && inside)
                    {
                        count++;
                    }
                    y += step;
                }
                y = 0;
                x += step;
            }

            x = step * (-1);
            y = 0;
            while (x >= radius*(-1))
            {
                while (y <= radius)
                {
                    if (x > aX && x < bX && y < cY && y > bY && inside)
                    {
                        count++;
                    }
                    y += step;
                }
                y = 0;
                x -=step;
            }

            x = step * (-1);
            y = step*(-1);
            while (x >= radius*(-1))
            {
                while (y >= -radius)
                {
                    if (x > aX && x < bX && y < cY && y > bY && inside)
                    {
                        count++;
                    }
                    y -= step;
                }
                y = step * (-1);
                x -= step;
            }

            x = 0;
            y = step * (-1);
            while (x <= radius)
            {
                while (y >= -radius)
                {
                    if (x > aX && x < bX && y < cY && y > bY && inside)
                    {
                        count++;
                    }
                    y -= step;
                }
                y = step * (-1);
                x += step;
            }

            Console.WriteLine(count);



        }
    }
}