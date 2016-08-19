using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14ModifyAbitAtP
{
    class ModifyABitAtP
    {
        static void Main(string[] args)
        {
            start:
            Console.Write("Please enter an integer number n= ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The number {0} in binary is: {1}", n, Convert.ToString(n,2).PadLeft(16, '0'));
            Console.Write("Please enter the position of the bit you want to switch: ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Please enter the value of the bit (0 or 1) you want to replace \'p\' with: ");
            int v = int.Parse(Console.ReadLine());
            int switcher;
            int result;
            if (v==0)
            {
                switcher = ~(1 << p);
                result = n & switcher;
                Console.WriteLine("Your new number in binary is {0} and it\'s integer representation is {1}", Convert.ToString(result, 2).PadLeft(16, '0'), result);

            }
            else
            {
                switcher = 1 << p;
                result = n | switcher;
                Console.WriteLine("Your new number in binary is {0} and it\'s integer representation is {1}", Convert.ToString(result, 2).PadLeft(16, '0'), result);
            }
            goto start;
        }
    }
}
