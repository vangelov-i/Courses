using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 15:57 - 16:10 
class Program
{
    static void Main(string[] args)
    {
        checked
        {

            double data = double.Parse(Console.ReadLine());
            double cinemaTicket = double.Parse(Console.ReadLine());
            double wifeRate = double.Parse(Console.ReadLine());

            double moviesDL = data / 1500d;
            double neededTime = (data / 2d) / 3600d;
            double wifeExpense = neededTime * wifeRate;
            double cinemaExpenses = moviesDL * cinemaTicket;

            if (cinemaExpenses < wifeExpense)
            {
                Console.WriteLine("cinema -> {0:F2}lv", cinemaExpenses);
            }
            else
            {
                Console.WriteLine("mall -> {0:F2}lv", wifeExpense);
            }

        }
    }
}