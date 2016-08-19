using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12ExtractBitFromInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer number n= ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please anter the position of the bit you want to extract from \'n\': ");
            int p = int.Parse(Console.ReadLine());
            int bitAtP = (n >> p) & 1;
            Console.WriteLine("The bit of the number {0} at position {1} is {2}", n, p, bitAtP);
        }
    }
}
