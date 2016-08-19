using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15BitsExchange
{
    class BitsExchange
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            //we take a pair of 3 bits from the given number by using the number 7, 
            //because it's representation in binary is 111
            uint mask3 = 7 << 3;
            //Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
            //Console.WriteLine(Convert.ToString(mask3, 2).PadLeft(32, '0'));
            uint newN3 = n & mask3;
            //Console.WriteLine(Convert.ToString(newN3, 2).PadLeft(32, '0'));
            uint bits345 = newN3 >> 3;
            //Console.WriteLine(Convert.ToString(bits345, 2).PadLeft(32, '0'));
            //Console.WriteLine();
            //Console.WriteLine();


            uint mask24 = 7 << 24;
            //Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
            //Console.WriteLine(Convert.ToString(mask24, 2).PadLeft(32, '0'));
            uint newN24 = n & mask24;
            //Console.WriteLine(Convert.ToString(newN24, 2).PadLeft(32, '0'));
            uint bits242526 = newN24 >> 24;
            //Console.WriteLine(Convert.ToString(bits242526, 2).PadLeft(32, '0'));
            //Console.WriteLine();
            //Console.WriteLine();

            uint xOr = bits345 ^ bits242526;
            uint first3BitsSwitched = n ^ (xOr << 3);
            uint finalNumber = first3BitsSwitched ^ (xOr << 24);
            Console.WriteLine("binary representation of n:");
            Console.WriteLine(Convert.ToString(n,2).PadLeft(32, '0'));
            Console.WriteLine("binary result:");
            Console.WriteLine(Convert.ToString(finalNumber,2).PadLeft(32, '0'));
            Console.WriteLine("new integer result: {0}", finalNumber);
        }
    }
}
