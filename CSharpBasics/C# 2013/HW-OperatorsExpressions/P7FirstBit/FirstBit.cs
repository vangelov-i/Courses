using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7FirstBit
{
    class FirstBit
    {
        static void Main()
        {
            start:
            //int n = int.Parse(Console.ReadLine());
            Console.Write("Enter an integer number to see it\'s bit in position 1: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(n,2).PadLeft(4,'0'));
            n = n >> 1;
            int bitAtPosition1 = n & 1;
            Console.WriteLine(bitAtPosition1);
            goto start;
        }
    }
}
