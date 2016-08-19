using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 11:56 - 12:09
class Program
{
    static void Main(string[] args)
    {
        checked
        {

            double rubles = double.Parse(Console.ReadLine());
            double dollars = double.Parse(Console.ReadLine());
            double euro = double.Parse(Console.ReadLine());
            double twoGamesLeva = double.Parse(Console.ReadLine());
            double oneGameLeva = double.Parse(Console.ReadLine());

            double rConv = (rubles / 100)*3.5;
            double dConv = dollars * 1.5;
            double eConv = euro * 1.95;
            double twoGPrice = twoGamesLeva * 0.5;
            double oneGPrice = oneGameLeva;

            double bestPrice = Math.Min(rConv, dConv);
            bestPrice = Math.Min(bestPrice, eConv);
            bestPrice = Math.Min(bestPrice, twoGPrice);
            bestPrice = Math.Min(bestPrice, oneGPrice);

            Console.WriteLine("{0:F2}", bestPrice);



        }
    }
}