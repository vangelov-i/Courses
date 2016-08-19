using System;

namespace P9PrintASequence
{
    class PrintASequence
    {
        static void Main()
        {
            int a = -1;
            for (int i = 2; i <= 11; i++)
            {
                a *= -1;
                Console.WriteLine(i*a);
            }
        }
    }
}
