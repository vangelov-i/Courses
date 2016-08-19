using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 11:25 - 11:42  -> 80/100 //   11:25 - 11:55  -> 100
class Program
{
    static void Main(string[] args)
    {
        checked
        {


            int[,] matrix = new int[32, 32];
            int num = 0;
            string temp = string.Empty;

            for (int i = 0; i < 8; i++)
            {
                num = int.Parse(Console.ReadLine());
                temp = Convert.ToString(num, 2).PadLeft(32,'0');
                //Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));
                for (int j = 0; j < 32; j++)
                {
                    matrix[i, j] = int.Parse(temp[j].ToString());
                }
            }
            //Console.WriteLine("--------------------------");
            //for (int i = 0; i < 8; i++)
            //{
            //    for (int j = 0; j < 8; j++)
            //    {
            //        Console.Write(matrix[i, j]);
            //    }
            //    Console.WriteLine();
            //}


            int counter = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    if (matrix[i,j] == 1 && matrix[i,j+1] == 0 && matrix[i,j+2] == 1)
                    {
                        if (matrix[i+1,j] == 0 && matrix[i+1,j+1] == 1 && matrix[i+1,j+2] == 0)
                        {
                            if (matrix[i+2,j] == 1 && matrix[i+2,j+1] == 0 && matrix[i+2,j+2] == 1)
                            {
                                counter++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(counter);

        }
    }
}