using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 15:40 -  16:30 !!!!!!!!!!! yes beeeee!!!! 100 tochki ot pyrviq pyt !!!!! zemi!

namespace _11AprilMorning04MagicStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int diff = int.Parse(Console.ReadLine());

            int[] letters = { 3, 4, 1, 5 }; // s,n,k,p
            int firstSum = 0;
            int secondSum = 0;
            string lettersOutput = string.Empty;
            List<string> outputsList = new List<string>();
            bool magicFound = false;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        for (int l = 0; l < 4; l++)
                        {
                            firstSum = letters[i] + letters[j] + letters[k] + letters[l];
                            for (int m = 0; m < 4; m++)
                            {
                                for (int n = 0; n < 4; n++)
                                {
                                    for (int o = 0; o < 4 ; o++)
                                    {
                                        for (int p = 0; p < 4; p++)
                                        {
                                            secondSum = letters[m] + letters[n] + letters[o] + letters[p];
                                            if (secondSum - diff == firstSum)
                                            {
                                                lettersOutput = letters[i].ToString() + letters[j].ToString() + letters[k].ToString() + letters[l].ToString() 
                                                              + letters[m].ToString() + letters[n].ToString() + letters[o].ToString() + letters[p].ToString();
                                                outputsList.Add(lettersOutput);
                                                magicFound = true;
                                            }
                                            else if (firstSum - diff == secondSum)
                                            {
                                                lettersOutput = letters[i].ToString() + letters[j].ToString() + letters[k].ToString() + letters[l].ToString()
                                                              + letters[m].ToString() + letters[n].ToString() + letters[o].ToString() + letters[p].ToString();
                                                outputsList.Add(lettersOutput);
                                                magicFound = true;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (magicFound)
            {
                string finalOutputs = string.Empty;
                List<string> finalOutputsList = new List<string>();

                foreach (var str in outputsList)
                {
                    foreach (var number in str)
                    {
                        switch (number)
                        {
                            case '3':
                                finalOutputs += "s";
                                break;
                            case '4':
                                finalOutputs += "n";
                                break;
                            case '5':
                                finalOutputs += "p";
                                break;
                            case '1':
                                finalOutputs += "k";
                                break;
                        }
                    }
                    finalOutputsList.Add(finalOutputs);
                    finalOutputs = string.Empty;
                }

                finalOutputsList.Sort();
                foreach (var str in finalOutputsList)
                {
                    Console.WriteLine(str);
                }
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
