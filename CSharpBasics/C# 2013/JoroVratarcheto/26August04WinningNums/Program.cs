using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 11:12 - 11:22  ->  100 
class Program
{
    static void Main(string[] args)
    {
        checked
        {


            string s = Console.ReadLine();
            s = s.ToUpper();
            int letSum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                letSum += s[i] - 64;
            }
            bool winningFound = false;
            for (int i = 0; i < 10; i++)
            {
                for (int i1 = 0; i1 < 10; i1++)
                {
                    for (int i2 = 0; i2 < 10; i2++)
                    {


                        if (i*i1*i2 == letSum)
                        {
                            for (int j = 0; j < 10; j++)
                            {
                                for (int j1 = 0; j1 < 10; j1++)
                                {
                                    for (int j2 = 0; j2 < 10; j2++)
                                    {


                                        if (j*j1*j2 == letSum)
                                        {
                                            Console.WriteLine("{0}{1}{2}-{3}{4}{5}",i,i1,i2,j,j1,j2);
                                            winningFound = true;
                                        }


                                    }
                                }
                            }
                        }


                    }
                }
            }
            if (winningFound == false)
            {
                Console.WriteLine("No");
            }

        }
    }
}