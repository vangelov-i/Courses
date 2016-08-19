using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//10:15 - 11:15 /// 1 chas 100 tochki !

class Program
{
    static void Main(string[] args)
    {
        int w = int.Parse(Console.ReadLine());

        long weight1 = 0L;
        long weight2 = 0L;
        long weight3 = 0L;
        long weight4 = 0L;
        long weight5 = 0L;
        long totalWeight = 0L;
        int counter = 0;

        for (int i = 1; i < 11; i++)
        {
            for (int i1 = i + 1; i1 < i + 2; i1++)
            {
                for (int i2 = i1 + 1; i2 < i1 + 2; i2++)
                {
                    for (int i3 = i2 + 1; i3 < i2 + 2; i3++)
                    {
                        for (int i4 = i3 + 1; i4 < i3 + 2; i4++)
                        {
                            // straight combos
                            for (int s = 1; s < 5; s++)
                            {
                                for (int s1 = 1; s1 < 5; s1++)
                                {
                                    for (int s2 = 1; s2 < 5; s2++)
                                    {
                                        for (int s3 = 1; s3 < 5; s3++)
                                        {
                                            for (int s4 = 1; s4 < 5; s4++)
                                            {
                                                weight1 = 10 * i;
                                                weight2 = 20 * i1;
                                                weight3 = 30 * i2;
                                                weight4 = 40 * i3;
                                                weight5 = 50 * i4;


                                                weight1 += s;
                                                weight2 += s1;
                                                weight3 += s2;
                                                weight4 += s3;
                                                weight5 += s4;
                                                totalWeight = weight1 + weight2 + weight3 + weight4 + weight5;
                                                if (totalWeight == w)
                                                {
                                                    //Console.WriteLine("{0},{1} {2},{3} {4},{5} {6},{7} {8},{9}", i, s, i1, s1, i2, s2, i3, s3, i4, s4);
                                                    counter++;
                                                }
                                                weight1 = 0L;
                                                weight2 = 0L;
                                                weight3 = 0L;
                                                weight4 = 0L;
                                                weight5 = 0L;
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



        Console.WriteLine(counter);

    }
}
