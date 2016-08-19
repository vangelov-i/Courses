using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {

        int candidates = int.Parse(Console.ReadLine());
        int chosen = int.Parse(Console.ReadLine());
        string symbol = Console.ReadLine().ToUpper();

        bool x = symbol == "x" || symbol == "X";
        bool v = symbol == "v" || symbol == "V";
        int height = candidates * 6 + 1;
        int width = 14;

        for (int i = 0; i < candidates; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                if (j == 0)
                {
                    Console.Write(new string('.', 13));
                }
                else if (j == 1 || j == 5)
                {
                    Console.Write(new string('.', 3));
                    Console.Write("+");
                    Console.Write(new string('-', 5));
                    Console.Write("+");
                    Console.Write(new string('.', 3));
                }
                else if ((j == 2 || j == 4) && i + 1 != chosen)
                {
                    Console.Write("...|.....|...");
                }
                else if (j == 3 && i + 1 != chosen)
                {
                    if (i + 1 < 10)
                    {
                        Console.Write("0{0}.|.....|...", i + 1);
                    }
                    else
                    {
                        Console.Write("{0}.|.....|...", i + 1);
                    }
                }
                else
                {
                    if (x)
                    {
                        Console.WriteLine("...|.\\./.|...");
                        if (chosen < 10)
                        {
                            Console.WriteLine("0{0}.|..{1}..|...", chosen, symbol);
                        }
                        else
                        {
                            Console.WriteLine("{0}.|..{1}..|...", chosen, symbol);
                        }
                        Console.WriteLine("...|./.\\.|...");
                        Console.WriteLine("...+-----+...");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("...|\\.../|...");
                        if (chosen < 10)
                        {
                            Console.WriteLine("0{0}.|.\\./.|...", chosen);
                        }
                        else
                        {
                            Console.WriteLine("{0}.|.\\./.|...", chosen);
                        }
                        Console.WriteLine("...|..{0}..|...",symbol);
                        Console.WriteLine("...+-----+...");
                        break;
                    }
                }
                Console.WriteLine();
            }
            if (i == candidates - 1)
            {
                Console.WriteLine(new string('.',13));
            }
        }



    }
}