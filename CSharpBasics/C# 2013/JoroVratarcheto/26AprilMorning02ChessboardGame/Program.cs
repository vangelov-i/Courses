using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 16:55 - 17:24 -> 60/100  // 17:35 - 18:00  -> 100  !!! edin shiban propusnat "+" mi otne  35 min !!! 
class Program
{
    static void Main(string[] args)
    {
        checked
        {

            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int[,] table = new int[n, n];
            //int index = 0;
            int whites = 0;
            int blacks = 0;

            for (int i = 0; i < n * n; i++)
            {
                if (i < input.Length)
                {
                    if (Char.IsDigit(input[i % input.Length]) || Char.IsLetter(input[i % input.Length]))
                    {
                        char test = input[i % input.Length];
                        //table[i, j] = input[index];
                        if (i % 2 == 0)
                        {
                            if (input[i % input.Length] < 91 && input[i % input.Length] > 64)
                            {
                                whites += input[i % input.Length];
                            }
                            else
                            {
                                blacks += input[i % input.Length];
                            }
                        }
                        else
                        {
                            if (input[i % input.Length] < 91 && input[i % input.Length] > 64)
                            {
                                blacks += input[i % input.Length];
                            }
                            else
                            {
                                whites += input[i % input.Length];
                            }
                        }
                    }
                }
                //index++;
            }

            if (blacks > whites)
            {
                Console.WriteLine("The winner is: black team");
                Console.WriteLine(blacks - whites);
            }
            else if (whites > blacks)
            {
                Console.WriteLine("The winner is: white team");
                Console.WriteLine(whites - blacks);
            }
            else
            {
                Console.WriteLine("Equal result: {0}", whites);
            }


        }
    }
}