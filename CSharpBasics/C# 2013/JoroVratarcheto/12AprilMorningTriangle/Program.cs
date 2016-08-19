using System;
using System.Globalization;
using System.Threading;

namespace _12AprilMorningTriangle
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            double aX = double.Parse(Console.ReadLine());
            double aY = double.Parse(Console.ReadLine());
            double bX = double.Parse(Console.ReadLine());
            double bY = double.Parse(Console.ReadLine());
            double cX = double.Parse(Console.ReadLine());
            double cY = double.Parse(Console.ReadLine());


            double bXMinusAX = bX - aX;
            double bYMinusAY = bY - aY;
            double c = Math.Sqrt(Math.Pow(bXMinusAX, 2) + Math.Pow(bYMinusAY, 2));

            double cXMinusBX = cX - bX;
            double cYMinusBY = cY - bY;
            double a = Math.Sqrt(Math.Pow(cXMinusBX, 2) + Math.Pow(cYMinusBY, 2));

            double aXMinusCX = aX - cX;
            double aYMinusCY = aY - cY;
            double b = Math.Sqrt(Math.Pow(aXMinusCX, 2) + Math.Pow(aYMinusCY, 2));

            double p = (a + b + c)/2.0;
            double area = Math.Round((Math.Sqrt(p*(p - a)*(p - b)*(p - c))),2);

            if (a + b > c && b + c > a && a + c > b)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("{0:F2}",area);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("{0:F2}",c);
            }
        }
    }
}

//if (aX - aY == bX - bY && bX - bY == cX - cY)
//{
//    triangle = "No";
//}
