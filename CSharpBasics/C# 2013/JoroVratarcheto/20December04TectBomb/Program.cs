using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 09:05 - 09:55  -  75/100  +30 -> 100
class Program
{
    static void Main(string[] args)
    {
        checked
        {

            string text = Console.ReadLine();
            int width = int.Parse(Console.ReadLine());
            string[] strBombs = Console.ReadLine().Split(' ');

            List<int> bombs = new List<int>();
            for (int i = 0; i < strBombs.Length; i++)
            {
                int temp = int.Parse(strBombs[i]);
                bombs.Add(temp);
            }

            double tempRows = text.Length / (double)width;
            int rows = 0;
            if (tempRows % 1 != 0)
            {
                rows = (int)tempRows + 1;
            }
            else
            {
                rows = (int)tempRows;
            }

            int[,] table = new int[rows, width];
            int counter = 0;
            bool[] bombedOnce = new bool[bombs.Count];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    table[i, j] = text[counter++ % text.Length];
                    if (bombs.Contains(j))
                    {
                        if (table[i, j] == ' ' && bombedOnce[bombs.IndexOf(j)] == true)
                        {
                            bombs[bombs.IndexOf(j)] = -1;
                        }
                        else
                        {
                            if (table[i, j] != ' ')
                            {
                                bombedOnce[bombs.IndexOf(j)] = true;
                            }
                            table[i, j] = ' ';
                        }
                    }
                    if (counter <= text.Length)
                    {
                        Console.Write((char)table[i, j]);
                    }
                }
            }
            Console.WriteLine();


        }
    }
}