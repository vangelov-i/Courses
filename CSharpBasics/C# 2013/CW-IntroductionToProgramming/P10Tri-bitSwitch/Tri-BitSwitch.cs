using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10Tri_bitSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            long mask = 7 << p;
            //  0011011
            //  0011100
            //  0010101
            //
     //TODO: Make the mask needed to invert 3 bits at position p
            long result = n ^ mask;

            Console.WriteLine(result);

        }
    }
}
