using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {

        int people = int.Parse(Console.ReadLine());
        int choosen = int.Parse(Console.ReadLine());
        string symbol = Console.ReadLine().ToUpper();

        for (int i = 0; i < people; i++)
        {
            if (i + 1 != choosen)
            {
                Console.WriteLine(".............\n...+-----+...\n...|.....|...\n{0}.|.....|...\n...|.....|...\n...+-----+...", (i + 1).ToString().PadLeft(2, '0'));
            }
            else
            {
                if (symbol == "X")
                {
                    Console.WriteLine(".............\n...+-----+...\n...|.\\./.|...\n{0}.|..X..|...\n...|./.\\.|...\n...+-----+...",choosen.ToString().PadLeft(2,'0'));
                }
                else
                {
                    Console.WriteLine("\n...+-----+...\n...|\\.../|...\n{0}.|.\\./.|...\n...|..V..|...\n...+-----+...", choosen.ToString().PadLeft(2, '0'));
                }
            }
            if (i == people - 1)
            {
                Console.WriteLine(new string('.',13));
            }

        }
    }
}