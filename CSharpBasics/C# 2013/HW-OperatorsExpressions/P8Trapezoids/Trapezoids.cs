using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8Trapezoids
{
    class Trapezoids
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the sides and height (h) of a trapezoid: ");
            Console.Write("a = ");
            double sideA = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double sideB = double.Parse(Console.ReadLine());
            Console.Write("h = ");
            double height = double.Parse(Console.ReadLine());
            double area = ((sideA + sideB) / 2) * height;
            Console.WriteLine("The area of the trapezoid is: {0}",area);
        }
    }
}
