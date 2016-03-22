using System;

namespace _01Point3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D test = new Point3D(0, 1, 2);
            Console.WriteLine(test.ToString()); // but the output will be the same without using ".ToString()"
        }
    }
}
