using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 10:45 - 
class Program
{
    static void Main(string[] args)
    {
        string strSecretNum = Console.ReadLine();
        int bulls = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());

        int digit = int.Parse(strSecretNum[0].ToString());
        int digit1 = int.Parse(strSecretNum[1].ToString());
        int digit2 = int.Parse(strSecretNum[2].ToString());
        int digit3 = int.Parse(strSecretNum[3].ToString());

        int digitCounter = strSecretNum.Count(f => f == strSecretNum[0]);
        int digit1Counter = strSecretNum.Count(f => f == strSecretNum[1]);
        int digit2Counter = strSecretNum.Count(f => f == strSecretNum[2]);
        int digit3Counter = strSecretNum.Count(f => f == strSecretNum[3]);



        int countBulls = 0;
        int countCows = 0;

        string temp = string.Empty;
        string checker = string.Empty;
        List<string> guessNumList = new List<string>();
        int excludedCowI = 0;
        int excludedCowI1 = 0;
        int excludedCowI2 = 0;

        int excludedBulli = 0;
        int excludedBulli1 = 0;
        int excludedbulli2 = 0;
        int excludedbulli3 = 0;


        int tempDig = 0;
        int temp1Dig = 0;
        int temp2Dig = 0;
        int temp3Dig = 0;


        for (int i = 1; i < 10; i++)
        {
            for (int i1 = 1; i1 < 10; i1++)
            {
                for (int i2 = 1; i2 < 10; i2++)
                {
                    for (int i3 = 1; i3 < 10; i3++)
                    {
                        checker = i.ToString() + i1 + i2 + i3;
                        // bulls count
                        if (i == digit)
                        {
                            countBulls++;
                            excludedBulli = i;
                        }
                        if (i1 == digit1)
                        {
                            countBulls++;
                            excludedBulli1 = i1;
                        }
                        if (i2 == digit2)
                        {
                            countBulls++;
                            excludedbulli2 = i2;
                        }
                        if (i3 == digit3)
                        {
                            countBulls++;
                            excludedbulli3 = i3;
                        }

                        if (countBulls == bulls && cows == 0)
                        {
                            temp = i.ToString() + i1 + i2 + i3;
                            guessNumList.Add(temp);
                        }
                        if (countBulls == bulls)
                        {
                            if (cows != 0)
                            {
                                int test = checker.Count(f => f == checker[checker.IndexOf(i1.ToString())]);
                                //cows count
                                if (i != excludedBulli && i != digit && (i == digit1 || i == digit2 || i == digit3))
                                {
                                    if (checker.Count(f => f == checker[checker.IndexOf(i.ToString())]) <= strSecretNum.Count(f => f == strSecretNum[strSecretNum.IndexOf(i.ToString())]))
                                    {
                                        countCows++;
                                        excludedCowI = i1;
                                    }
                                }
                                if (i1 != excludedCowI && i1 != excludedBulli1 && i1 != digit1 && (i1 == digit || i1 == digit2 || i1 == digit3))
                                {
                                    if (checker.Count(f => f == checker[checker.IndexOf(i1.ToString())]) <= strSecretNum.Count(f => f == strSecretNum[strSecretNum.IndexOf(i1.ToString())]))
                                    {
                                        countCows++;
                                        excludedCowI1 = i1;
                                    }
                                }
                                if (i2 != excludedCowI && i2 != excludedCowI1 && i2 != excludedbulli2 && i2 != digit2 && (i2 == digit || i2 == digit1 || i2 == digit3))
                                {
                                    if (checker.Count(f => f == checker[checker.IndexOf(i2.ToString())]) <= strSecretNum.Count(f => f == strSecretNum[strSecretNum.IndexOf(i2.ToString())]))
                                    {
                                        countCows++;
                                        excludedCowI2 = i2;
                                    }
                                }
                                if (i3 != excludedCowI && i3 != excludedCowI1 && i3 != excludedCowI2 && i3 != excludedbulli3 && i3 != digit3 && (i3 == digit || i3 == digit1 || i3 == digit2))
                                {
                                    if (checker.Count(f => f == checker[checker.IndexOf(i3.ToString())]) <= strSecretNum.Count(f => f == strSecretNum[strSecretNum.IndexOf(i3.ToString())]))
                                    {
                                        countCows++;
                                    }
                                }

                                if (countCows == cows)
                                {
                                    temp = i.ToString() + i1 + i2 + i3;
                                    guessNumList.Add(temp);

                                    //tempDig = temp.Count(f => f == temp[0]);
                                    //temp1Dig = temp.Count(f => f == temp[1]);
                                    //temp2Dig = temp.Count(f => f == temp[2]);
                                    //temp3Dig = temp.Count(f => f == temp[3]);

                                    //if (i == digit)
                                    //{
                                    //    if (tempDig > digitCounter)
                                    //    {
                                    //        guessNumList.Remove(temp);
                                    //    }
                                    //}
                                    //else if (i == digit1)
                                    //{
                                    //    if (tempDig > digit1Counter)
                                    //    {
                                    //        guessNumList.Remove(temp);
                                    //    }
                                    //}
                                    //else if (i == digit2)
                                    //{
                                    //    if (tempDig > digit2Counter)
                                    //    {
                                    //        guessNumList.Remove(temp);
                                    //    }
                                    //}
                                    //else if (i == digit3)
                                    //{
                                    //    if (tempDig > digit3Counter)
                                    //    {
                                    //        guessNumList.Remove(temp);
                                    //    }
                                    //}

                                    //if (i1 == digit)
                                    //{
                                    //    if (temp1Dig > digitCounter)
                                    //    {
                                    //        guessNumList.Remove(temp);
                                    //    }
                                    //}
                                    //else if (i1 == digit1)
                                    //{
                                    //    if (temp1Dig > digit1Counter)
                                    //    {
                                    //        guessNumList.Remove(temp);
                                    //    }
                                    //}
                                    //else if (i1 == digit2)
                                    //{
                                    //    if (temp1Dig > digit2Counter)
                                    //    {
                                    //        guessNumList.Remove(temp);
                                    //    }
                                    //}
                                    //else if (i1 == digit3)
                                    //{
                                    //    if (temp1Dig > digit3Counter)
                                    //    {
                                    //        guessNumList.Remove(temp);
                                    //    }
                                    //}


                                    //if (i2 == digit)
                                    //{
                                    //    if (temp2Dig > digitCounter)
                                    //    {
                                    //        guessNumList.Remove(temp);
                                    //    }
                                    //}
                                    //else if (i2 == digit1)
                                    //{
                                    //    if (temp2Dig > digit1Counter)
                                    //    {
                                    //        guessNumList.Remove(temp);
                                    //    }
                                    //}
                                    //else if (i2 == digit2)
                                    //{
                                    //    if (temp2Dig > digit2Counter)
                                    //    {
                                    //        guessNumList.Remove(temp);
                                    //    }
                                    //}
                                    //else if (i2 == digit3)
                                    //{
                                    //    if (temp2Dig > digit3Counter)
                                    //    {
                                    //        guessNumList.Remove(temp);
                                    //    }
                                    //}



                                    //if (i3 == digit)
                                    //{
                                    //    if (temp3Dig > digitCounter)
                                    //    {
                                    //        guessNumList.Remove(temp);
                                    //    }
                                    //}
                                    //else if (i3 == digit1)
                                    //{
                                    //    if (temp3Dig > digit1Counter)
                                    //    {
                                    //        guessNumList.Remove(temp);
                                    //    }
                                    //}
                                    //else if (i3 == digit2)
                                    //{
                                    //    if (temp3Dig > digit2Counter)
                                    //    {
                                    //        guessNumList.Remove(temp);
                                    //    }
                                    //}
                                    //else if (i3 == digit3)
                                    //{
                                    //    if (temp3Dig > digit3Counter)
                                    //    {
                                    //        guessNumList.Remove(temp);
                                    //    }
                                    //}


                                }
                            }
                        }
                        countBulls = 0;
                        countCows = 0;
                        excludedBulli = excludedBulli1 = excludedbulli2 = excludedbulli3 = excludedCowI = excludedCowI1 = excludedCowI2 = 0;

                    }
                }
            }
        }
        guessNumList = guessNumList.Distinct().ToList();
        guessNumList.Sort();


        if (guessNumList.Count > 0)
        {
            for (int i = 0; i < guessNumList.Count; i++)
            {
                if (i < guessNumList.Count - 1)
                {
                    Console.Write("{0} ", guessNumList[i]);
                }
                else
                {
                    Console.WriteLine(guessNumList[i]);
                }
            }
        }
        else
        {
            Console.WriteLine("No");
        }




    }
}
