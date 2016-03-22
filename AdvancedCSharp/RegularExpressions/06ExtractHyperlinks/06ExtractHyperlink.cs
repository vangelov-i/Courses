namespace _06ExtractHyperlinks
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    class ExtractHyperlink
    {
        static void Main()
        {
            var concatanatedInput = new StringBuilder();
            string inputLine = string.Empty;

            while (inputLine != "END")
            {
                inputLine = Console.ReadLine();

                concatanatedInput.Append(inputLine);
            }

            string wholeInput = concatanatedInput.ToString();

            string pattern = @"<a[^>]+href\s*=\s*(?<quotes>[\'\""]?)(.*?)(\k<quotes>)(>|\s)";
            var regex = new Regex(pattern);

            var matches = regex.Matches(wholeInput);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[1]);
            }
        }
    }
}
