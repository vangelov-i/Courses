using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10PointInACircleAndoutsideRectangle
{
    class PointCircleRectangle
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the X-axis of a point in coordinate system: ");
            double x = double.Parse(Console.ReadLine()) - 1; // this way (-1) we make the circle's center be {0, 0} so we can later do our calcs easier.
            Console.Write("Please enter the Y-axis of a point in coordinate system: ");
            double y = double.Parse(Console.ReadLine()) - 1;
            double hypotenuse = Math.Sqrt(x * x + y * y);
            bool insideKOutsideR = x >= -0.5 && x <= 2.5 && y <= 2.5 && y > 0 && hypotenuse <= 1.5;
            Console.WriteLine("The point with coordinates ({0}, {1}) is in the circle K and out of the rectangle R {2}", x+1, y+1, insideKOutsideR);
        }
    }
}
