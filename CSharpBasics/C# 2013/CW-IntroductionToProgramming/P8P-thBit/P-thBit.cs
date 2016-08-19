using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8P_thBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int bitAtPositionP = (n >> p) & 1;
            Console.WriteLine(bitAtPositionP);
        }
    }
}
