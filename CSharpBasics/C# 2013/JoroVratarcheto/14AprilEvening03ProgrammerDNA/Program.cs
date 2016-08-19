using System;

//09:15 - .... #izmachihSa

namespace _14AprilEvening03ProgrammerDNA
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char letter = char.Parse(Console.ReadLine());
            int letterNo = (int)letter;

            int dotsCount = 3;
            int raisingDots = 1;

            for (int i = 0; i < n; i++)
            {
                if (dotsCount > -1)
                {
                    Console.Write(new string('.', dotsCount));
                    for (int j = 0; j < 7 - dotsCount * 2; j++)
                    {
                        if (letterNo == 72)
                        {
                            letterNo = 65;
                        }
                        Console.Write((char)letterNo);
                        letterNo++;
                    }
                    Console.Write(new string('.', dotsCount));
                    dotsCount--;
                    Console.WriteLine();
                }
                else if (raisingDots < 4)
                {
                    Console.Write(new string('.', raisingDots));
                    for (int j = 0; j < 7 - raisingDots * 2; j++)
                    {
                        if (letterNo == 72)
                        {
                            letterNo = 65;
                        }
                        Console.Write((char)letterNo);
                        letterNo++;
                    }
                    Console.Write(new string('.', raisingDots));
                    raisingDots++;
                    Console.WriteLine();
                }
                else
                {
                    dotsCount = 3;
                    raisingDots = 1;
                    i--;
                }
            }
        }
    }
}
