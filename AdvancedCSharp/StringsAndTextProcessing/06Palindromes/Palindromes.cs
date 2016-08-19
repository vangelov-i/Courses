namespace _06Palindromes
{
    using System;
    using System.Collections.Generic;

    class Palindromes
    {
        static void Main()
        {
            char[] delimiters = { ' ', ',', '.', '?', '!' };
            string[] words = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            SortedSet<string> palindromes = new SortedSet<string>();

            for (int currentWord = 0; currentWord < words.Length; currentWord++)
            {
                string wordsFirstHalf = string.Empty;
                string wordsSecondHalfReversed = string.Empty;

                for (int currentChar = 0; currentChar < words[currentWord].Length / 2; currentChar++)
                {
                    wordsFirstHalf += words[currentWord][currentChar];
                }

                for (int currentChar = words[currentWord].Length - 1; currentChar >= words[currentWord].Length / 2; currentChar--)
                {
                    if (currentChar == words[currentWord].Length / 2 && words[currentWord].Length % 2 != 0)
                    {
                        break;
                    }

                    wordsSecondHalfReversed += words[currentWord][currentChar];
                }

                if (wordsFirstHalf == wordsSecondHalfReversed || words[currentWord].Length == 1)
                {
                    palindromes.Add(words[currentWord]);
                }
            }

            Console.WriteLine(string.Join(", ", palindromes));
        }
    }
}
