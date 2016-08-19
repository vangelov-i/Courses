using System;

namespace P8Triangle
{
    class Triangle
    {
        static void Main()
        {
            //char symbol = new char{'\u00A9', 10};
            string firstLine = "   \u00A9";
            string sedondLine = "  \u00A9 \u00A9";
            string thirdLine = " \u00A9   \u00A9";
            string lastLine = "\u00A9 \u00A9 \u00A9 \u00A9";
            Console.WriteLine("{0}\n{1}\n{2}\n{3}", firstLine, sedondLine, thirdLine, lastLine);
        }
    }
}
