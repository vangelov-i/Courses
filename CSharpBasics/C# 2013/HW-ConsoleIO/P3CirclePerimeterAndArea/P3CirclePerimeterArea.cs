using System;
using System.Text;

namespace P3CirclePerimeterAndArea
{
    class P3CirclePerimeterArea
    {
        static void Main()
        {
            float radius;
            Console.Write("Enter the radius: ");
            float.TryParse(Console.ReadLine(), out radius);
            Console.WriteLine("The perimeter of a circle with radius {0} is {1:F2}\nThe are of a circle with radius {0} is {2:F2}", radius, radius*2*Math.PI, radius*radius*Math.PI );
        }
    }
}
