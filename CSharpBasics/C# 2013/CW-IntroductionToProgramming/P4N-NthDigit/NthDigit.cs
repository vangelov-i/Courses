using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4N_NthDigit
{
    class NthDigit
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int nDigit = (number / (int)(Math.Pow(10, n - 1)) % 10);
            Console.WriteLine(nDigit);
        }
    }
}
