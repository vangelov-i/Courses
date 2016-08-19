using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8PrimesCheck
{
    class PrimesCheck
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int divisor = 1;
            while (divisor <= 100 && n <=100)
            {
                divisor += 1;
                if (n == 1)
                {
                    Console.WriteLine("false");
                    break;
                }
                if (n % divisor == 0 && divisor != n)
                {
                    Console.WriteLine("false");
                    break;
                }
                if (n % divisor == 0 && divisor == n)
                {
                    Console.WriteLine("true");
                    break;
                }
            }
        }
    }
}
