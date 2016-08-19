using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5BigandOdd
{
    class BigAndOdd
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool result = (n > 20) && (n % 2 == 1);
            Console.WriteLine(result);
        }
    }
}
