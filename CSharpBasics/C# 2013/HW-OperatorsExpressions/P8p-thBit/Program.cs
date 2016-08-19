using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8p_thBit
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please enter an integer number: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please enter the bit\'s position you want to check: ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("The number {0} in binary is ", n);
            Console.WriteLine(Convert.ToString(n,2));
            n = n >> p;
            int bitAtPositionP = n & 1;
            Console.WriteLine("And [ {0} ] is the bit with position {1}.", bitAtPositionP,p);
            Console.WriteLine();
        }
    }
}
