namespace _04SentenceExtractor
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class SentenceExtractor
    {
        static void Main()
        {
            string filterWord = Console.ReadLine();

            string sentence = Console.ReadLine();

            string pattern = string.Format(
                @"(?<=[\.\!\?] |^)[A-Z][^\.\!\?]+(?<=\s|^){0}(?=[\s\.\?\!])[\w\s\-]*[\.\?\!]", 
                filterWord);
            var regex = new Regex(pattern);

            var matches = regex.Matches(sentence);

            string[] sentences = matches.Cast<Match>().Select(m => m.Value).ToArray();

            Console.WriteLine(string.Join("\n", sentences));
        }
    }
}
