namespace _05ValidUsernames
{
    using System;
    using System.Text.RegularExpressions;

    public class ValidUsernames
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"(?<=^|[\ \/\(\)\\])([a-zA-Z]\w{2,24})(?=\W|$)";

            Regex regex = new Regex(pattern);
            var matches = regex.Matches(input);

            int maxConsecontiveUsernamesLenght = 0;
            int indexOfCouple = -1;

            for (int currentMatch = 0; currentMatch < matches.Count; currentMatch++)
            {
                var a = matches[1];
                if (currentMatch != matches.Count - 1)
                {
                    int currentMatchLenght = matches[currentMatch].Value.Length;
                    int nextMatchLenght = matches[currentMatch + 1].Value.Length;
                    if (currentMatchLenght + nextMatchLenght > maxConsecontiveUsernamesLenght)
                    {
                        maxConsecontiveUsernamesLenght = currentMatchLenght + nextMatchLenght;
                        indexOfCouple = currentMatch;
                    }
                }
            }

            if (indexOfCouple != -1)
            {
                Console.WriteLine(matches[indexOfCouple].Value);
                Console.WriteLine(matches[indexOfCouple + 1].Value);
            }
        }
    }
}