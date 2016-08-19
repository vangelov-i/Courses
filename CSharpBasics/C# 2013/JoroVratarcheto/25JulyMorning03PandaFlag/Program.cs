using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 13:40 - 13:55
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int letter = 65;
        int firstHalf = 0;

        for (int i = 0; i < n; i++)
        {
            if (i< n/2)
            {
                Console.Write(new string('~', firstHalf));
                Console.Write((char)letter);
                letter++;
                if (letter == 91)
                {
                    letter = 65;
                }
                Console.Write(new string('#', n - 2 - firstHalf*2));
                Console.Write((char)letter);
                letter++;
                if (letter == 91)
                {
                    letter = 65;
                }
                Console.Write(new string('~', firstHalf));
                firstHalf++;
            }
            else if (i == n/2)
            {
                Console.Write(new string('-', (n - 1)/2));
                Console.Write((char)letter);
                letter++;
                if (letter == 91)
                {
                    letter = 65;
                }
                Console.Write(new string('-', (n - 1) / 2));
                firstHalf--;
            }
            else if (i > n/2)
            {
                Console.Write(new string('~', firstHalf));
                Console.Write((char)letter);
                letter++;
                if (letter == 91)
                {
                    letter = 65;
                }
                Console.Write(new string('#', n - 2 - firstHalf * 2));
                Console.Write((char)letter);
                letter++;
                if (letter == 91)
                {
                    letter = 65;
                }
                Console.Write(new string('~', firstHalf));
                firstHalf--;
            }
            Console.WriteLine();
        }



    }
}

