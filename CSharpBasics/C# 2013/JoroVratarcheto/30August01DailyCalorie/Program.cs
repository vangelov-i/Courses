using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
// 12:31 - 12:41 -> 100
class Program
{
    static void Main(string[] args)
    {
        checked
        {

            decimal weight = decimal.Parse(Console.ReadLine()) / 2.2m;
            decimal height = decimal.Parse(Console.ReadLine()) * 2.54m;
            decimal age = decimal.Parse(Console.ReadLine());
            string sex = Console.ReadLine();
            decimal workOuts = decimal.Parse(Console.ReadLine());

            decimal bmrMen = 66.5m + (13.75m * weight) + (5.003m * height) - (6.755m * age);
            decimal bmrWomen = 655 + (9.563m * weight) + (1.85m * height) - (4.676m * age);

            decimal dci = 0m;

            if (sex == "m")
            {
                if (workOuts < 1)
                {
                    dci = bmrMen * 1.2m;
                }
                else if (workOuts < 4)
                {
                    dci = bmrMen * 1.375m;
                }
                else if (workOuts < 7)
                {
                    dci = bmrMen * 1.55m;
                }
                else if (workOuts < 10)
                {
                    dci = bmrMen * 1.725m;
                }
                else
                {
                    dci = bmrMen * 1.9m;
                }
            }
            else
            {
                if (workOuts < 1)
                {
                    dci = bmrWomen * 1.2m;
                }
                else if (workOuts < 4)
                {
                    dci = bmrWomen * 1.375m;
                }
                else if (workOuts < 7)
                {
                    dci = bmrWomen * 1.55m;
                }
                else if (workOuts < 10)
                {
                    dci = bmrWomen * 1.725m;
                }
                else
                {
                    dci = bmrWomen * 1.9m;
                }
            }

            Console.WriteLine(Math.Floor(dci));


        }
    }
}