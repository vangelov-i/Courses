using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//13:20 - 15:00  90/100
class Program
{
    static void Main(string[] args)
    {
        checked
        {


            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int distance = int.Parse(Console.ReadLine());

            int[] arrA = new int[a.Length];
            int[] arrB = new int[b.Length];

            int sumA = 0;
            for (int i = 0; i < a.Length; i++)
            {
                arrA[i] = (int)a[i];
                sumA += (int)a[i];
            }
            int sumB = 0;
            for (int i = 0; i < b.Length; i++)
            {
                arrB[i] = (int)b[i];
                sumB += (int)b[i];
            }

            int leftA = 0;
            int rightA = 0;
            int leftB = 0;
            int rightB = 0;

            int[] variationsA = new int[(arrA.Length - 1)*2];

            for (int i = 0, j = 0; i < arrA.Length -1; i++, j+=2)
            {
                leftA += arrA[i];
                rightA = sumA - leftA;
                variationsA[j] = leftA;
                variationsA[j + 1] = rightA;
                //Console.WriteLine("aLeft:  {0}",variationsA[j]);
                //Console.WriteLine("aRight: {0}", variationsA[j+1]);
            }
            //Console.WriteLine("----------------------------------");
            int[] variationsB = new int[(arrB.Length - 1)*2];
            for (int i = 0, j = 0; i < arrB.Length - 1; i++, j+=2)
            {
                leftB += arrB[i];
                rightB = sumB - leftB;
                variationsB[j] = leftB;
                variationsB[j + 1] = rightB;
                //Console.WriteLine("aLeft:  {0}", variationsB[j]);
                //Console.WriteLine("aRight: {0}", variationsB[j + 1]);
            }

            string aLeft = string.Empty;
            string aRight = string.Empty;
            string bLeft = string.Empty;
            string bRight = string.Empty;
            bool printed = false;
            //Console.WriteLine(variationsA.Length);
            //Console.WriteLine(variationsB.Length);
            for (int i = 0; i < variationsA.Length; i+=2)
            {
                for (int j = 0; j < variationsB.Length; j+=2)
                {
                    int result = Math.Abs(variationsA[i] * variationsB[j+1] - variationsA[i + 1] * variationsB[j]);
                    //Console.WriteLine("aLeft: {0}", variationsA[i]);
                    //Console.WriteLine("Right: {0}", variationsA[i+1]);
                    //Console.WriteLine("-------");
                    //Console.WriteLine("bLeft:  {0}", variationsB[j]);
                    //Console.WriteLine("bRight: {0}", variationsB[j+1]);
                    //Console.WriteLine("````````````````");
                    if (result <= distance)
                    {
                        for (int k = 0; k <= i/2; k++)
                        {
                            aLeft += a[k].ToString();
                            if (k == i/2)
                            {
                                for (int r = k+1; r < a.Length; r++)
                                {
                                    aRight += a[r].ToString();
                                }
                            }
                        }
                        for (int m = 0; m <= j/2; m++)
                        {
                            bLeft += b[m].ToString();
                            if (m == j/2)
                            {
                                for (int s = m+1; s < b.Length; s++)
                                {
                                    bRight += b[s].ToString();
                                }
                            }
                        }
                        printed = true;
                        Console.WriteLine("({0}|{1}) matches ({2}|{3}) by {4} nakovs",aLeft,aRight,bLeft,bRight,result);
                        aLeft = string.Empty;
                        aRight = string.Empty;
                        bLeft = string.Empty;
                        bRight = string.Empty;
                    }
                }
            }

            if (!printed)
            {
                Console.WriteLine("No");
            }

        }
    }
}