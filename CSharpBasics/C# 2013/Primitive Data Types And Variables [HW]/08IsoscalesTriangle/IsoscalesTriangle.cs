using System;
using System.Text;

namespace _08IsoscalesTriangle
{
    class IsoscalesTriangle
    {
        static void Main()
        {
            //Write a program that prints an isosceles triangle
            //of 9 copyright symbols ©, something like this:
            //       ©
            //      © ©
            //     ©   ©
            //    © © © ©
            //Note that the © symbol may be displayed incorrectly 
            //at the console so you may need to change the console
            //character encoding to UTF-8 and assign a Unicode-friendly
            //font in the console. Note also, that under old versions of 
            //Windows the © symbol may still be displayed incorrectly,
            //regardless of how much effort you put to fix it.

            Console.OutputEncoding = Encoding.UTF8;
            char symbol = '\u00A9';
            //Console.WriteLine(symbol);
            string firstLine = string.Format("   " + symbol);
            string secondLine = string.Format("  " + symbol + " " + symbol);
            string thirdLine = string.Format(" " + symbol + "   " + symbol);
            string fourthLine = string.Format(symbol + " " + symbol + " " + symbol + " " + symbol);
            Console.WriteLine(firstLine);
            Console.WriteLine(secondLine);
            Console.WriteLine(thirdLine);
            Console.WriteLine(fourthLine);

        }
    }
}
