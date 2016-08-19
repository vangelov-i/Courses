using System;

namespace _04PrintADeck
{
    class PrintADeck
    {
        static void Main()
        {
            char[] array = { '\u2660', '\u2665', '\u2666', '\u2663' };
            for (int i = 2; i <= 14 ; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i < 11)
                    {
                        Console.Write("{0}{1} ",i, array[j]);
                    }
                    switch (i)
                    {
                        case 11:
                            Console.Write("J{0} ", array[j]);
                            break;
                        case 12:
                            Console.Write("Q{0} ", array[j]);
                            break;
                        case 13:
                            Console.Write("K{0} ", array[j]);
                            break;
                        case 14:
                            Console.Write("A{0} ", array[j]);
                            break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
