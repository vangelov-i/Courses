using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13CheckAbitAtP
{
    class CheckABitAtP
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer number n= ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please anter the position of the bit you want to extract from \'n\': ");
            int p = int.Parse(Console.ReadLine());
            int bitAtP = (n >> p) & 1;
            bool isBitAtP1 = bitAtP == 1;
            Console.WriteLine("The bit of number {0} at position {1} is 1: {2}", n, p, isBitAtP1);
        }
    }
}
