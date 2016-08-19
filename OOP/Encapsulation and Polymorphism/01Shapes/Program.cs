using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Shapes
{
    using Shapes;
    using Interfaces;
    class Program
    {
        static void Main(string[] args)
        {
            IShape[] shapes = 
            {
                new Circle(3.5),
                new Rectangle(4,7),
                new Rhombus(2,3)
            };

            foreach (IShape shape in shapes)
            {
                Console.WriteLine("Type: " + shape.GetType().Name + "\nArea: " + shape.CalculateArea());
                Console.WriteLine("Perimeter: " + shape.CalculatePerimeter());
            }

        }
    }
}
