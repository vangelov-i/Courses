using _01Point3D;
using System;

namespace _02DistanceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D firstP = new Point3D(0, 0, 0);
            Point3D secondP = new Point3D(1, 2, 3);

            Console.WriteLine("The distance between {0} and {1} is {2}",firstP, secondP, DistanceCalculator.Calculate(firstP,secondP));
        }
    }
}
