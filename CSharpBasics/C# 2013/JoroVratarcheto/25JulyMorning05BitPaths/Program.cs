using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//16:15 - 15:25    100 tochki !!! 

class Program
{
    static void Main(string[] args)
    {
        checked
        {


            int paths = int.Parse(Console.ReadLine());

            string strPath = string.Empty;
            int[] arrPath = new int[8];
            int[] rows = {0,0,0,0,0,0,0,0};
            int mask = 0;

            int position = 0;
            decimal sum = 0M;
            for (int i = 0; i < paths; i++)
            {

                strPath = Console.ReadLine();
                string[] path = strPath.Split(',');
                for (int j = 0; j < 8; j++)
                {
                    arrPath[j] = int.Parse(path[j]);
                }
                position = 3 - int.Parse(strPath[0].ToString());
                for (int k = 0; k < 8; k++)
                {
                    mask = 1 << position + (arrPath[k] * -1);
                    if (k == 0)
                    {
                        rows[0] = rows[0] ^ (1 << position);
                    }
                    else
                    {
                        rows[k] = rows[k] ^ mask;
                        position = position + (arrPath[k] * -1);
                    }
                    //Console.WriteLine(Convert.ToString(rows[k], 2).PadLeft(4, '0'));
                    //rows[2] = rows[2] ^ (1 << position + arrPath[2] * (-1));
                    //rows[3] = rows[3] ^ (1 << position + arrPath[3] * (-1));
                    //rows[4] = rows[4] ^ (1 << position + arrPath[4] * (-1));
                    //rows[5] = rows[5] ^ (1 << position + arrPath[5] * (-1));
                    //rows[6] = rows[6] ^ (1 << position + arrPath[6] * (-1));
                    //rows[7] = rows[7] ^ (1 << position + arrPath[7] * (-1));

                }
                //Console.WriteLine("Next Path:");

            }


            //decimal test = 11 + 13 + 13 + 4 + 14 + 8 + 14 + 8;
            //Console.WriteLine(test);
            for (int i = 0; i < 8; i++)
            {
                sum += rows[i];
            }
            //Console.WriteLine(sum);
            Console.WriteLine(Convert.ToString((int)sum, 2));
            Console.WriteLine("{0:X}", (int)sum);
            //Console.WriteLine("{0:X}", sum);
            //Console.WriteLine((decimal)rows[0]);
            //Console.WriteLine((decimal)rows[1]);
            //Console.WriteLine((decimal)rows[2]);
            //Console.WriteLine((decimal)rows[3]);
            //Console.WriteLine((decimal)rows[4]);
            //Console.WriteLine((decimal)rows[5]);
            //Console.WriteLine((decimal)rows[6]);
            //Console.WriteLine((decimal)rows[7]);


        }
    }
}
