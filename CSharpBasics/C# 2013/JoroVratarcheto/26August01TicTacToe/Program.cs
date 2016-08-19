using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 
class Program
{
    static void Main(string[] args)
    {
        checked
        {


            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());

            int[,] arr = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = v++;
                }
            }

            int indexOfNum = (y + 1) * 3 - (2 - x);
            long num = (long)Math.Pow(arr[y, x], indexOfNum);
            Console.WriteLine(num);
        }
    }
}