namespace _01SeriesOfLetters
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class SeriesOfLetters
    {
        static void Main()
        {
            string message = Console.ReadLine();

            string pattern = @"([A-Za-z])(?!\1)";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(message);

            string result = string.Join(string.Empty, matches.Cast<Match>().Select(x => x.Value));

            Console.WriteLine(result);
        }
    }
}
