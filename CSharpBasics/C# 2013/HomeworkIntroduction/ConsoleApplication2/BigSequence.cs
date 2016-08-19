using System;

namespace BigSequence
{
    class Sequence
    {
        static void Main()
        {
            int a = -1;
            for (int i = 2; i <= 1001 ; i++)
            {
                a = a * -1;
                int b = i * a;
                Console.WriteLine(b);
            }
        }
    }
}