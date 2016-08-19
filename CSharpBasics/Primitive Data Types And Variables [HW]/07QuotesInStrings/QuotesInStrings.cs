using System;

namespace _07QuotesInStrings
{
    class QuotesInStrings
    {
        static void Main()
        {
            //Declare two string variables and assign them with following value:
            //The "use" of quotations causes difficulties.
            //Do the above in two different ways: with and without using quoted strings.
            //Print the variables to ensure that their value was correctly defined.
            //Expected Output
            //The "use" of quotations causes difficulties.
            //The "use" of quotations causes difficulties.

            string firstWay = "The \"use\" of quatations causes difficulties.";
            string secondWay = @"The ""use"" of quatations causes difficulties.";
            Console.WriteLine(firstWay);
            Console.WriteLine(secondWay);
        }
    }
}