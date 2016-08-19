using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 21:02 - 21:12 -> 100
class Program
{
    static void Main(string[] args)
    {
        checked
        {

            decimal FG = decimal.Parse(Console.ReadLine());
            decimal FGA = decimal.Parse(Console.ReadLine());
            decimal P3 = decimal.Parse(Console.ReadLine());
            decimal TOV = decimal.Parse(Console.ReadLine());
            decimal ORB = decimal.Parse(Console.ReadLine());
            decimal OppDRB = decimal.Parse(Console.ReadLine());
            decimal FT = decimal.Parse(Console.ReadLine());
            decimal FTA = decimal.Parse(Console.ReadLine());

            decimal OuteFG = (FG + 0.5m * P3) / FGA;
            decimal outTOV = TOV / (FGA + 0.44m * FTA + TOV);
            decimal outORB = ORB / (ORB + OppDRB);
            decimal outFT = FT / FGA;

            Console.WriteLine("eFG% {0:F3}", OuteFG);
            Console.WriteLine("TOV% {0:F3}", outTOV);
            Console.WriteLine("ORB% {0:F3}", outORB);
            Console.WriteLine("FT% {0:F3}", outFT);
        }
    }
}