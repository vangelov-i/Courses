namespace _02ReplaceATag
{
    using System;
    using System.Text.RegularExpressions;

    class ReplaceATag
    {
        static void Main()
        {
            // reading input from a single line
            string input = Console.ReadLine();

            // opitvah s imenuvani grupi, no taka i ne razbrah kak da gi izvikvam otdolu
            // v changePattern-a i zatova si ostanaha taka grozni, bez imena s $2, $3, $5 i t.n.
            // ako znaesh kak stava, molq te, drasni edin komentar v recenziqta
            string pattern = @"(""|')(.+)<a (.+(?<quotes>""|').+\k<quotes>(?=>\w+))>(\w+)<\/a>(.+)\1";
            string changePattern = "$2[URL $3]$5[/URL]$6";

            var regex = new Regex(pattern);

            string result = regex.Replace(input, string.Format("{0}[URL {1}]{2}[/URL]{3}", regex.Match(input).Groups[2]));

            Console.WriteLine(result);
        }
    }
}
