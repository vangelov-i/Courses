using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 16:15 - 16:40 -> 100
class Program
{
    static void Main(string[] args)
    {
        checked
        {
            int n = int.Parse(Console.ReadLine());
            string fon = Console.ReadLine();
            string sharka = Console.ReadLine();

            int height = 4 * n + 1;
            int width = height;
            int counterSharkaDown = n;
            int vytre = 1;


            for (int i = 0; i < height; i++)
            {
                if (i == 0 || i == n * 2 || i == height - 1)
                {
                    Console.Write(new string(fon[0], counterSharkaDown));
                    Console.Write(sharka);
                    Console.Write(new string(fon[0], width - 2 - counterSharkaDown * 2));
                    Console.Write(sharka);
                    Console.Write(new string(fon[0], counterSharkaDown));
                    counterSharkaDown--;
                }
                else if (i < n || i > n * 2 && i < n * 3)
                {
                    if (i == n * 2 + 1)
                    {
                        vytre += 2;
                    }
                    Console.Write(new string(fon[0], counterSharkaDown));
                    Console.Write(sharka);
                    Console.Write(new string(fon[0], vytre));
                    Console.Write(sharka);
                    Console.Write(new string(fon[0], width - 4 - vytre * 2 - counterSharkaDown * 2));
                    Console.Write(sharka);
                    Console.Write(new string(fon[0], vytre));
                    Console.Write(sharka);
                    Console.Write(new string(fon[0], counterSharkaDown));
                    counterSharkaDown--;
                    vytre += 2;
                }
                else if (i == n || i == n * 3)
                {
                    Console.Write(new string(fon[0], counterSharkaDown));
                    Console.Write(sharka);
                    Console.Write(new string(fon[0], vytre));
                    Console.Write(sharka);
                    Console.Write(new string(fon[0], vytre));
                    Console.Write(sharka);
                    Console.Write(new string(fon[0], counterSharkaDown));
                    counterSharkaDown++;
                    vytre -= 2;
                }
                else if (i > n)
                {
                    Console.Write(new string(fon[0], counterSharkaDown));
                    Console.Write(sharka);
                    Console.Write(new string(fon[0], vytre));
                    Console.Write(sharka);
                    Console.Write(new string(fon[0], width - 4 - vytre * 2 - counterSharkaDown * 2));
                    Console.Write(sharka);
                    Console.Write(new string(fon[0], vytre));
                    Console.Write(sharka);
                    Console.Write(new string(fon[0], counterSharkaDown));
                    counterSharkaDown++;
                    vytre -= 2;
                }
                Console.WriteLine();
            }




        }
    }
}