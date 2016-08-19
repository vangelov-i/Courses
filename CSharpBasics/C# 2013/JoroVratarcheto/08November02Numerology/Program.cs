using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 16: 03 - 18:00 !! // reshena, no trqbva da se reshi pak s po prost nachin

namespace _08November02Numerology
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arrWhole = input.Split(' ', '.');
            string name = arrWhole[3];
            int month = int.Parse(arrWhole[1]);

            long multipl = 1;
            int number = 0;
            for (int i = 0; i < arrWhole.Length - 1; i++)
            {
                number = int.Parse(arrWhole[i]);
                multipl *= number;
            }
            if (month % 2 != 0)
            {
                multipl *= multipl;
            }

            int digitsSum = 0;
            for (int i = 0; i < name.Length; i++)
            {
                if (Char.IsDigit(name[i]))
                {
                    digitsSum += name[i] - 48;
                }
                else if (Char.IsUpper(name[i]))
                {
                    digitsSum += (Math.Abs((int)name[i] - 64) * 2);
                }
                else
                {
                    digitsSum += (Math.Abs((int)name[i] - 96));
                }
            }
            multipl += digitsSum;
            string strMultipl = multipl.ToString();
            int celestialNumPre = 0;
            for (int i = 0; i < strMultipl.Length; i++)
            {
                celestialNumPre += (int)strMultipl[i] - 48;
            }
            if (celestialNumPre > 13)
            {
                string strCelestialPre = celestialNumPre.ToString();
                int celestialNum = 0;
                for (int i = 0; i < strCelestialPre.Length; i++)
                {
                    celestialNum += (int)strCelestialPre[i] - 48;
                }

                if (celestialNum > 13)
                {
                    string strCel = celestialNum.ToString();
                    int nextCel = 0;
                    for (int i = 0; i < strCel.Length; i++)
                    {
                        nextCel += (int)strCel[i] - 48;
                    }
                    if (nextCel > 13)
                    {
                        string str2cel = nextCel.ToString();
                        int nextcel2 = 0;
                        for (int i = 0; i < str2cel.Length; i++)
                        {
                            nextcel2 += (int)str2cel[i] - 48;
                        }
                        Console.WriteLine(nextcel2);
                    }
                    else
                    {
                        Console.WriteLine(nextCel);
                    }
                }
                else
                {
                    Console.WriteLine(celestialNum);
                }

            }
            else
            {
                Console.WriteLine(celestialNumPre);
            }

        }

    }
}
