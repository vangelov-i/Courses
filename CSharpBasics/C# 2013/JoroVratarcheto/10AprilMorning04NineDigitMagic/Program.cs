using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//16:00 -  17:00  //  podvejdashto uslovie !!! pishe abc < def < ghi , a vsyshtnost e <= (po malko ili ravno)

namespace _10AprilMorning04NineDigitMagic
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int diff = int.Parse(Console.ReadLine());

            //string firstT = string.Empty;
            //string secondT = string.Empty;
            //string thirdT = string.Empty;

            int numFirstT = 0;
            int numSecondT = 0;
            int numThirdT = 0;
            int wholeNum = 0;
            bool magicFound = false;

            var list = new List<int>();

            for (int i = 1; i < 8; i++)
            {
                for (int j = 1; j < 8; j++)
                {
                    for (int k = 1; k < 8; k++)
                    {
                        for (int l = 1; l < 8; l++)
                        {
                            for (int m = 1; m < 8; m++)
                            {
                                for (int n = 1; n < 8; n++)
                                {
                                    numFirstT = Convert.ToInt32(i.ToString() + j.ToString() + k.ToString());
                                    numSecondT = Convert.ToInt32(l.ToString() + m.ToString() + n.ToString());
                                    if (numSecondT - numFirstT == diff)
                                    {
                                        for (int o = 1; o < 8; o++)
                                        {
                                            for (int p = 1; p < 8; p++)
                                            {
                                                for (int q = 1; q < 8; q++)
                                                {
                                                    if (i <= l && l <= o)
                                                    {
                                                        if (i + j + k + l + m + n + o + p + q == sum)
                                                        {
                                                            numThirdT = Convert.ToInt32(o.ToString() + p.ToString() + q.ToString());
                                                            if ((numThirdT - numSecondT) == diff)
                                                            {
                                                                wholeNum = Convert.ToInt32(numFirstT.ToString() + numSecondT.ToString() + numThirdT.ToString());
                                                                magicFound = true;
                                                                list.Add(wholeNum);
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (!magicFound)
            {
                Console.WriteLine("No");
            }
            else
            {
                var array = list.ToArray();
                Array.Sort(array);
                foreach (var number in array)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}