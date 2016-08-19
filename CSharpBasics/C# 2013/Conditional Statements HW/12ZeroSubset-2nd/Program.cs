using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12ZeroSubset_2nd
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //int d = int.Parse(Console.ReadLine());
            //int e = int.Parse(Console.ReadLine());
            //int sum = a + b + c + d + e;

            int[] array1 = { 1, 3, -4, -2, -1 };

            int indexJ = 0;
            int indexK = 1;
            int indexL = 2;
            int indexM = 3;
            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                if (indexK == 5)
                {
                    indexJ++;
                }
                if (indexK > 4)
                {
                    indexK = indexJ + 1;
                }
                sum = array1[indexJ] + array1[indexK];
                if (sum == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", array1[indexJ], array1[indexK]);
                }
                indexK++;
            }

            indexJ = 0;
            indexK = 1;
            indexL = 2;
            sum = 0;

            for (int i = 1 ; i <= 10 ; i++)
            {
                if (indexK == 3)
                {
                    indexJ++;
                }
                if (indexL == 5 && indexK < 3)
                {
                    indexK++;
                }
                if (indexL == 5)
                {
                    indexL = indexK + 1;
                }
                sum = array1[indexJ] + array1[indexK] + array1[indexL];
                if (sum == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", array1[indexJ], array1[indexK], array1[indexL]);
                }
                indexL++;
            }


            indexJ = 0;
            indexK = 1;
            indexL = 2;
            indexM = 3;
            sum = 0;

            for (int i = 1 ; i <=5 ; i++)
            {
                if (indexM == 5 && indexL <3)
                {
                    indexL +=1;
                }
                if (indexL == 3 && indexK <2)
                {
                    indexK +=1;
                }
                if (indexK == 2 && indexJ <1)
                {
                    indexJ += 1; 
                }
                sum = array1[indexJ] + array1[indexK] + array1[indexL] + array1[indexM];
                if (sum == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} + {3} = 0", array1[indexJ], array1[indexK], array1[indexL], array1[indexM]);
                }
                indexM++;
            }












            //for (int i = 1; i <= 10; i++) // 5 elementa 2-ri klas
            //{
            //    if (startPoint + arr2Point == 0 && j <3)
            //    {
            //        Console.WriteLine("{0} + {1} = 0",array1[i], array2[i]);
            //    }
            //    j++;
            //    arr2Point = array2[j];
            //}

            //for (int i = 1 ; i <= 10 ; i++) // 5 elementa 3-ti klas
            //{

            //}
            //for (int i = 1 ; i <=5 ; i++)
            //{

            //}
        }
    }
}
