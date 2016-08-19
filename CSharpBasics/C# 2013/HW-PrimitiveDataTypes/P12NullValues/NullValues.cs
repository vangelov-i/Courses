using System;

namespace P12NullValues
{
    class NullValues
    {
        static void Main()
        {
            int? number = null;
            double? number1 = null;
            Console.WriteLine("{0} {1}", number, number1);
            number = + +5;
            number1 = + +2.3;
            Console.WriteLine("{0} {1}",number, number1);
        }
    }
}
