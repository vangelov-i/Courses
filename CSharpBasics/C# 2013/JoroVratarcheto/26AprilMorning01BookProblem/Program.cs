using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 16:15 - 16:55  -> 100 
class Program
{
    static void Main(string[] args)
    {
        checked
        {

            double pagesBook = double.Parse(Console.ReadLine());
            double camping = double.Parse(Console.ReadLine());
            double readRateDay = double.Parse(Console.ReadLine());

            if (camping == 30 || readRateDay == 0)
            {
                Console.WriteLine("never");
            }
            else
            {
                double PagesPerMonth = (30 - camping) * readRateDay;
                double monthsNeeded = (pagesBook / PagesPerMonth);
                monthsNeeded = Math.Ceiling(monthsNeeded);
                if (monthsNeeded == 0)
                {
                    Console.WriteLine("0 years 1 months");
                }
                else
                {
                    Console.WriteLine("{0} years {1} months", (long)(monthsNeeded / 12), (long)(monthsNeeded % 12));
                }
            }

        }
    }
}