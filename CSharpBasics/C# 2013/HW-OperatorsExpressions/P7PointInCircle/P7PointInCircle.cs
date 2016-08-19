using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7PointInCircle
{
    class P7PointInCircle
    {
        static void Main()
        {
            start:
            Console.Write("Please enter the X-axis of a point in coordinate system: ");
            double x = Math.Abs(double.Parse(Console.ReadLine()));
            Console.Write("Please enter the Y-axis of a point in coordinate system: ");
            double y = Math.Abs(double.Parse(Console.ReadLine()));
            double hypotenuse = Math.Sqrt(x*x  + y*y);
            bool insideSircle = x <= 2 && y <= 2 && hypotenuse <= 2;
            Console.WriteLine("The point with with coordinates ({0},{1}) is in the circle: {2}",x,y,insideSircle);
            goto start;
            // 2*x + 2*y >4
        }
    }
}
