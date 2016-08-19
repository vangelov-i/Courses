using System;

//Write an expression that checks if given integer is odd or even. Examples:
//n	    Odd?
//3	    true
//2	    false
//-2	false
//-1	true
//0	    false

namespace _01OddOrEvenInt
{
    class OddOrEvenInt
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool isOdd = n % 2 != 0;
            Console.WriteLine(isOdd);
        }
    }
}
