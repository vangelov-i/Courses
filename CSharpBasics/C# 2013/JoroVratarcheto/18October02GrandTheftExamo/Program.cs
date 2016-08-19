using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 17:08 - 17:17 -> 100
class Program
{
    static void Main(string[] args)
    {
        checked
        {
            int n = int.Parse(Console.ReadLine());

            long totalBeers = 0;
            long slapped = 0;
            long escaped = 0;
            for (int i = 0; i < n; i++)
            {

                long thieves = long.Parse(Console.ReadLine());
                long beers = long.Parse(Console.ReadLine());
                if (thieves < 6)
                {
                    slapped += thieves;
                }
                else if (thieves > 5)
                {
                    slapped += 5;
                    escaped += thieves - 5;
                }
                totalBeers += beers;
            }

            long sixPacks = totalBeers / 6;
            long bottles = totalBeers % 6;

            Console.WriteLine("{0} thieves slapped.", slapped);
            Console.WriteLine("{0} thieves escaped.", escaped);
            Console.WriteLine("{0} packs, {1} bottles.", sixPacks, bottles);


        }
    }
}