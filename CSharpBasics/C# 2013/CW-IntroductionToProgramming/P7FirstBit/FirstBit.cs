using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7FirstBit
{
    class FirstBit
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Your number in binary is: {0}", Convert.ToString(n,2));
            int bitAtPosition1 = (n >> 1) & 1;
            Console.WriteLine("The bit at position [1] is {0}",bitAtPosition1);
        }
    }
}
