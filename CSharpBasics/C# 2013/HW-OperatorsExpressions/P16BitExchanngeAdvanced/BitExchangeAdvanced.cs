using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16BitExchanngeAdvanced
{
    class BitExchangeAdvanced
    {
        static void Main(string[] args)
        {
            // if k = 3  , use 7 (000111)
            // if k = 10 , ise 1023 (0001111111111 -> ten times 1)
            // if k = 8 , use 255 (8x1)
            // if k = 11 , use 2047 (11x1)

            Console.Write("Enter number n: ");
            uint n = uint.Parse(Console.ReadLine());
            Console.Write("Enter position p: ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Enter position q: ");
            int q = int.Parse(Console.ReadLine());
            Console.Write("Enter position k: ");
            uint k = uint.Parse(Console.ReadLine());
            Console.WriteLine();

            if (p + k - 1 < q || q+k-1 < p && p>0 && p+k-1 < 31 && q>0 && q+k-1 <31)
            {
                uint bitNumWithOnes = (uint)Math.Pow(2, k) - 1;
                uint maskP = bitNumWithOnes << p;
                uint NewNP = n & maskP;
                uint bitsP = NewNP >> p;
                //Console.WriteLine(Convert.ToString(bitsP, 2).PadLeft(32, '0'));
                //Console.WriteLine();
                //Console.WriteLine();12345678
                uint maskQ = bitNumWithOnes << q;
                uint NewNQ = n & maskQ;
                uint bitsQ = NewNQ >> q;
                //Console.WriteLine(Convert.ToString(bitsQ, 2).PadLeft(32, '0'));
                //Console.WriteLine();
                //Console.WriteLine();
                uint xOr = bitsP ^ bitsQ;
                uint firstPBitsSwitched = n ^ (xOr << p);
                uint finalNumber = firstPBitsSwitched ^ (xOr << q);
                Console.WriteLine("binary representation of n:");
                Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
                Console.WriteLine("binary result:");
                Console.WriteLine(Convert.ToString(finalNumber, 2).PadLeft(32, '0'));
                Console.WriteLine("new integer result: {0}", finalNumber);
            }
            else if (p + k - 1 > q && q + k - 1 > p && p > 0 && p + k - 1 < 31 && q > 0 && q + k - 1 < 31) // this needs some second check
            {
                Console.WriteLine("overlapping");
            }
            else if (p < 0 || p+k-1 > 31 || q<0 || q+k-1 >31) // 1st version(p+k-1 < p || q+k-1 < q)
            {
                Console.WriteLine("out of range");
            }
        }
    }
}
