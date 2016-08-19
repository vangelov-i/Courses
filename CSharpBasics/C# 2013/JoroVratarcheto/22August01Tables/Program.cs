using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//13:22 - 13: 42 -> 100
class Program
{
    static void Main(string[] args)
    {
        checked
        {

            long bundle1 = long.Parse(Console.ReadLine());
            long bundle2 = long.Parse(Console.ReadLine());
            long bundle3 = long.Parse(Console.ReadLine());
            long bundle4 = long.Parse(Console.ReadLine());
            long tops = long.Parse(Console.ReadLine());
            long n = long.Parse(Console.ReadLine());

            long totalLegs = bundle1 + bundle2 * 2 + bundle3 * 3 + bundle4 * 4;
            long legsTables = totalLegs / 4;

            long madeTables = Math.Min(legsTables, tops);
            
            long topsLeft = tops - n;
            long legsLeft = totalLegs - 4 * n;
            
            long topsNeeded = n - tops;
            long legsNeeded = n * 4 - totalLegs;

            if (madeTables > n)
            {
                Console.WriteLine("more: {0}", madeTables - n);
                Console.WriteLine("tops left: {0}, legs left: {1}", topsLeft, legsLeft);
            }
            else if (madeTables < n)
            {
                Console.WriteLine("less: {0}", madeTables - n);
                if (tops < n && totalLegs >= 4*n)
                {
                    Console.WriteLine("tops needed: {0}, legs needed: 0", topsNeeded);
                }
                else if (totalLegs < 4*n && tops >= n)
                {
                    Console.WriteLine("tops needed: 0, legs needed: {1}", legsNeeded);
                }
                else
                {
                    Console.WriteLine("tops needed: {0}, legs needed: {1}", topsNeeded, legsNeeded);
                }
            }
            else
            {
                Console.WriteLine("Just enough tables made: {0}", n);
            }

        }
    }
}
