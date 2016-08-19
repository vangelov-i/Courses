using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
//08-47 - 09:03
class Program
{
    static void Main(string[] args)
    {
        checked
        {

            long rows = long.Parse(Console.ReadLine());
            long columns = long.Parse(Console.ReadLine());
            long startRows = long.Parse(Console.ReadLine());
            long startColumns = long.Parse(Console.ReadLine());

            long [,] table = new long[rows, columns];
            BigInteger num = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    num = startRows * startColumns++;
                    Console.Write("{0} ", num);
                }
                startColumns -= columns;
                startRows++;
                Console.WriteLine();
            }

            

        }
    }
}