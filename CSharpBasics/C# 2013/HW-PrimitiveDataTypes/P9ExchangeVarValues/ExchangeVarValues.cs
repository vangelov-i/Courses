using System;

namespace P9ExchangeVarValues
{
    class ExchangeVarValues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Before:\na = {0}\nb = {1}", a, b);
            b = a;
            a = a + a;
            Console.WriteLine("After:\na = {0}\nb = {1}", a, b);
        }
    }
}
