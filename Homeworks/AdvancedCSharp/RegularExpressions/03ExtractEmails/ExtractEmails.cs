namespace _03ExtractEmails
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class ExtractEmails
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string emailPattern =
                @"((?<=\s)[A-Za-z\d]+[\.\-_]?[A-Za-z\d]*@[A-Za-z]+\-?[A-Za-z]+\.?[A-Za-z]+\.[A-Za-z]+)";

            var regex = new Regex(emailPattern);

            string[] emails = regex.Matches(input).Cast<Match>().Select(m => m.Value).ToArray();

            Console.WriteLine(string.Join("\n", emails));
        }
    }
}