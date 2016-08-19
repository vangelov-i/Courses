using System;

namespace _04.MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            if ((a > 0 && b >0 && c>0) || (a<0 && b <0 && c >0) || (a>0 && b <0 && c<0) || (a <0 && b>0 && c<0))
            {
                Console.WriteLine("+");
            }
            else if (a == 0 || b==0 || c==0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("-");
            }
            // it's better and more logical "else if" and "else" places to be switched as "else" will happen more
            // often than "else if" but it was easier to do it this way than typing another long condition for
            // the cases we have "-" :D
        }
    }
}
