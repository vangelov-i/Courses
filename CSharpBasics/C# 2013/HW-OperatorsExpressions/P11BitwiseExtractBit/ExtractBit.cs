using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11BitwiseExtractBit
{
    class ExtractBit
    {
        static void Main(string[] args)
        {
            short n = short.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(n,2));
            n = (short)(n >> 3);
            n = (short)(n & 1);
            Console.WriteLine(n); // this is the bit at position #3
        }
    }
}
