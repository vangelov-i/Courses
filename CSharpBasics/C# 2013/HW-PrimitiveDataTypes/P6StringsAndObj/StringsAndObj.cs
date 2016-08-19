using System;

namespace P6StringsAndObj
{
    class StringsAndObj
    {
        static void Main()
        {
            string firstString = "Hello";
            string secondString = "World";
            object combined = firstString + " " + secondString;
            string casted = (string)combined;
            Console.WriteLine(casted);
        }
    }
}
