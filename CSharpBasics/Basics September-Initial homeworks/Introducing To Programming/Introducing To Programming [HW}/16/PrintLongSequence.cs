using System;

namespace P16PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main()
        {
            int a = -1;
            for (int i = 2; i <= 1001; i++)
            {
                a *= -1;
                Console.WriteLine(i * a);
            }
        }
    }
}
