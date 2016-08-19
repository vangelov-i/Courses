using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1OddOrEvenIntegers
{
    class P1OddOrEven
    {
        static void Main()
        {
            start:
            Console.Write("Please enter an integer number: ");
            int n = int.Parse(Console.ReadLine());
            bool odd = n % 2 == 1;
            Console.WriteLine("Is {0} Odd = {1}", n, odd);
            goto start;
        }
    }
}
