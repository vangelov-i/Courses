using System;

namespace _06StringAndObject
{
    class StringAndObject
    {
        static void Main()
        {
            //Declare two string variables and assign them with “Hello”
            //and “World”. Declare an object variable and assign it with
            //the concatenation of the first two variables (mind adding an
            //interval between). Declare a third string variable and initialize
            //it with the value of the object variable (you should perform type casting).

            string hi = "Hello";
            string world = "World";
            object combinedStrings = hi + " " + world;
            string objTostring = (string)combinedStrings;
            Console.WriteLine(objTostring);
        }
    }
}
