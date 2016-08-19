using System;

//Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} 
//of a given 32-bit unsigned integer. The first and the second sequence of bits may 
//not overlap. Examples:

//  n	            p	    q	    k		result

//  1140867093	    3	    24	    3		1107312677
//  4294901775	    24	    3	    3		4194238527
//  2369124121	    2	    22	    10		1907751121
//  987654321	    2	    8	    11	    overlapping
//  123456789	    26	    0	    7	    out of range
//  33333333333	    -1	    0	    33	    out of range

namespace _16BitExchange
{
    class BitExchange
    {
        static void Main()
        {
            start:
            long n = long.Parse(Console.ReadLine()); 
            //last n (33,333,333,333  is a 64 bit integer, so thats why i moved from 'uing' to 'long'
            //but this must be a mistake in the given task, cause it's said we'll be given 32-bit unsigned integers
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int bigger = Math.Max(p, q);
            int smaller = Math.Min(p, q);

            if (p < 0 || q < 0 || (p+k-1) > 31 || (q+k-1) > 31)
	        {
                Console.WriteLine("out of range");
	        }
            else if (bigger <= (smaller+k-1))
            {
                Console.WriteLine("overlapping");
            }
            else
            {
                uint bitsP = (uint)(n >> p) & (uint)(Math.Pow(2, k) - 1);
                uint bitsQ = (uint)(n >> q) & (uint)(Math.Pow(2, k) - 1);

                uint switcher = bitsP ^ bitsQ;

                n = n ^ (switcher << p);
                n = n ^ (switcher << q);

                Console.WriteLine(n);
            }
            goto start;
        }
    }
}