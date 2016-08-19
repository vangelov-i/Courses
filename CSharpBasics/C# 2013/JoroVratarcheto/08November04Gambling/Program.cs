using System;
using System.Globalization;
using System.Threading;
using System.Linq;

// 18:10 - 18:50  //  70 tochki

namespace _08November04Gambling
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; 

            decimal cash = decimal.Parse(Console.ReadLine());
            string[] secondLine = Console.ReadLine().Split(' ').ToArray();

            decimal strenght = 0M;
            decimal totalCombos = (decimal)Math.Pow(13, 4);
            for (int i = 0; i < secondLine.Length; i++)
            {
                switch (secondLine[i])
                {
                    case "J":
                        strenght += 11;
                        break;
                    case "Q":
                        strenght += 12;
                        break;
                    case "K":
                        strenght += 13;
                        break;
                    case "A":
                        strenght += 14;
                        break;
                    default:
                        strenght += decimal.Parse(secondLine[i]);
                        break;
                }
            }
            decimal counter = 0.0M;
            for (int i = 2; i < 15; i++)
            {
                for (int j = 2; j < 15; j++)
                {
                    for (int k = 2; k < 15; k++)
                    {
                        for (int l = 2; l < 15; l++)
                        {
                            if (i + j + k + l > strenght)
                            {
                                counter++;   
                            }  
                        }
                    }
                }
            }
            decimal chanceOfWinning = counter / totalCombos;
            if (chanceOfWinning < 0.50M)
            {
                Console.WriteLine("FOLD");
                Console.WriteLine("{0:F2}", cash * 2 * chanceOfWinning);
            }
            else
            {
                Console.WriteLine("DRAW");
                Console.WriteLine("{0:F2}", cash * 2 * chanceOfWinning);
            }
        }
    }
}
