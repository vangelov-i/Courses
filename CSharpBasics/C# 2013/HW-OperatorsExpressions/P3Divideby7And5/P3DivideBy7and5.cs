using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3Divideby7And5
{
    class P3DivideBy7and5
    {
        static void Main()
        {
            Console.Write("Please enter a number: ");
            int n = int.Parse(Console.ReadLine());
            bool dividable = n % 7 == 0 && n % 5 == 0;
            Console.WriteLine("Can {0} be divided by 7 and 5 without reminder: {1}", n, dividable);
        }
    }
}
