﻿using System;

namespace _01NumbersFrom1toN
{
    class NumbersFrom1toN
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                    Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
