using System;

//Write an expression that calculates rectangle’s perimeter and area
//by given width and height. Examples:

//width	height	perimeter	area
//3	4	14	    12
//2.5	3	    11	        7.5
//5	5	20	    25

namespace _04Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double perimeter = 2 * sideA + 2 * sideB;
            double area = sideA * sideB;
            Console.WriteLine("perimeter={0}", perimeter);
            Console.WriteLine("area={0}", area);
        }
    }
}
