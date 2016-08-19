using System;

namespace P7QuotesInStrings
{
    class QuotesInStrings
    {
        static void Main()
        {
            string quotes1 = "The \"use\" of quotations causes difficulties.";
            string quotes2 = @"The ""use"" of quatations causes difficulties.";
            Console.WriteLine("{0}\n{1}", quotes1, quotes2);
        }
    }
}
