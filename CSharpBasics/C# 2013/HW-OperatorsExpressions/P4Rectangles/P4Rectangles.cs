using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Rectangles
{
    class P4Rectangles
    {
        static void Main()
        {
            Console.Write("Please enter the height of a rectangle: ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("Please enter the width of a rectangle: ");
            double width = double.Parse(Console.ReadLine());
            double area = height * width;
            double perimeter = 2 * height + 2 * width;
            Console.WriteLine("The area of rectangle with height {0} and width {1} is {2}", height, width, area);
            Console.WriteLine("The perimeter of rectangle with height {0} and width {1} is {2}", height, width, perimeter);

        }
    }
}
