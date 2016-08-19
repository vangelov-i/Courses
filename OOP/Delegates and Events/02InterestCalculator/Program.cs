using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02InterestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var test1 = new InterestCalculator(500m, 5.6m, 10, GetCompoundInterest);
            Console.WriteLine(test1);


            var test2 = new InterestCalculator(2500m, 7.2m, 15, GetSimpleInterest);
            Console.WriteLine(test2);

        }

        public static decimal GetSimpleInterest(decimal money, decimal interest, int years)
        {
            return money * (1 + interest / 100 * years);
        }

        public static decimal GetCompoundInterest(decimal money, decimal interest, int years)
        {
            int monthsInYear = 12;
            // emi... grozno e, da. No vse pak mislq, che e po- dobre money i interest da si ostanat decimal
            // zashtoto smqtame pari, pyk Math.Pow raboti samo s double
            return (decimal)(((double)money) * Math.Pow((double)((1 + (interest / 100) / monthsInYear)), monthsInYear * years));
        }

    }
}
