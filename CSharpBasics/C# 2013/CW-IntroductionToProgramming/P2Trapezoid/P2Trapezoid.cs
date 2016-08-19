using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2Trapezoid
{
    class P2Trapezoid
    {
        static void Main()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float h = float.Parse(Console.ReadLine());
            float area = ((a + b) / 2) * h;
            Console.WriteLine(area);
        }
    }
}
