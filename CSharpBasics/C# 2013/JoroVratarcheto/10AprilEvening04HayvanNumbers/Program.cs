using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 22:45 - 23:40

class Program
{
    static void Main(string[] args)
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());

        int firstT = 0;
        int secondT = 0;
        int thirdT = 0;
        string tempSecond = string.Empty;
        string tempThird = string.Empty;
        string tempWhole = string.Empty;
        List<string> outputList = new List<string>();

        for (int i = 5; i < 10; i++)
        {
            for (int i1 = 5; i1 < 10; i1++)
            {
                for (int i2 = 5; i2 < 10; i2++)
                {
                    firstT = int.Parse(i.ToString() + i1 + i2);
                    secondT = firstT + diff;
                    thirdT = firstT + diff * 2;
                    tempSecond = secondT.ToString();
                    tempThird = thirdT.ToString();

                    if (i + i1 + i2 + (secondT / 100) + ((secondT % 100) / 10) + ((secondT % 100) % 10) + (thirdT / 100) + ((thirdT % 100) / 10) + ((thirdT % 100) % 10) == sum)
                    {
                        if (tempSecond.Length < 4 && 
                            !tempSecond.Contains("0") &&
                            !tempSecond.Contains("1") &&
                            !tempSecond.Contains("2") &&
                            !tempSecond.Contains("3") &&
                            !tempSecond.Contains("4") &&

                            tempThird.Length < 4 && (
                            !tempThird.Contains("0") &&
                            !tempThird.Contains("1") &&
                            !tempThird.Contains("2") &&
                            !tempThird.Contains("3") &&
                            !tempThird.Contains("4"))
                            )
                        {
                            tempWhole = firstT.ToString() + tempSecond + tempThird;
                            outputList.Add(tempWhole);
                        }
                    }
                }
            }
        }

        if (outputList.Count > 0)
        {
            outputList.Sort();
            foreach (var number in outputList)
            {
                Console.WriteLine(number);
            }
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
