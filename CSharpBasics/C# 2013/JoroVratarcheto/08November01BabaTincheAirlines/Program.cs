using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 12:45 - 13:20  //  35 min!

namespace _08November01BabaTincheAirlines
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string[] firstClassInfo = input1.Split();
            string input2 = Console.ReadLine();
            string[] businessClassInfo = input2.Split();
            string input3 = Console.ReadLine();
            string[] economyClassInfo = input3.Split();

            double firstClassPpl = double.Parse(firstClassInfo[0]);
            double firstClassFreqPpl = double.Parse(firstClassInfo[1]);
            double firstClassMeals = double.Parse(firstClassInfo[2]);

            double businessClassPpl = double.Parse(businessClassInfo[0]);
            double businessClassFreqPpl = double.Parse(businessClassInfo[1]);
            double businessClassMeals = double.Parse(businessClassInfo[2]);

            double economyClassPpl = double.Parse(economyClassInfo[0]);
            double economyClassFreqPpl = double.Parse(economyClassInfo[1]);
            double economyClassMeals = double.Parse(economyClassInfo[2]);

            double priceFirst = 7000;
            double priceBusiness = 3500;
            double priceEconomy = 1000;

            double mealPrice = 0.005;
            double discount = 0.3;

            double seatsFirst = 12;
            double seatsBusiness = 28;
            double seatsEconomy = 50;

            double maxProfit1 = seatsFirst * priceFirst + mealPrice * priceFirst * seatsFirst;
            double maxProfit2 = seatsBusiness * priceBusiness + mealPrice * priceBusiness * seatsBusiness;
            double maxprofit3 = seatsEconomy * priceEconomy + mealPrice * priceEconomy * seatsEconomy;


            double totalMaxProfit = (int)(maxProfit1 + maxProfit2 + maxprofit3);

            double realProfit1 = (firstClassPpl - firstClassFreqPpl) * priceFirst +
                                 firstClassFreqPpl * priceFirst * discount + 
                                 mealPrice * priceFirst * firstClassMeals;

            double realProfit2 = (businessClassPpl - businessClassFreqPpl) * priceBusiness +
                                 businessClassFreqPpl * priceBusiness * discount +
                                 mealPrice * priceBusiness * businessClassMeals;

            double realProfit3 = (economyClassPpl - economyClassFreqPpl) * priceEconomy +
                                 economyClassFreqPpl * priceEconomy * discount +
                                 mealPrice * priceEconomy * economyClassMeals;

            double totalRealProfit = (int)(realProfit1 + realProfit2 + realProfit3);

            Console.WriteLine(totalRealProfit);
            Console.WriteLine(totalMaxProfit - totalRealProfit);




        }
    }
}