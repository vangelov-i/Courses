using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9BitDestroyer
{
    class BitDestroyer
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int mask = ~(1 << p);
            int newNumber = n & mask;
            Console.WriteLine(newNumber);
        }
    }
}
