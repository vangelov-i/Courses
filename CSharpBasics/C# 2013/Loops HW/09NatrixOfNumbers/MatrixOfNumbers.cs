using System;

namespace _09NatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i);
                for (int j = 1; j < n; j++)
                {
                    Console.Write("  {0}",i+j);
                }
                Console.WriteLine();
            }
        }
    }
}
