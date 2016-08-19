using System;
using System.Collections.Generic;
using System.Text;

using Wintellect.PowerCollections;

public class FastStringSearchTextFile
{
    static void Main()
    {
        int substringsCount = int.Parse(Console.ReadLine());
        var substrings = new StringBuilder[substringsCount];
        for (int i = 0; i < substringsCount; i++)
        {
            substrings[i] = new StringBuilder(Console.ReadLine());
        }

        int textLinesCount = int.Parse(Console.ReadLine());

        //var textToSearchIn = new BigList<char>();
        var textToSearchIn = new StringBuilder();
        var substringOccurances = new Dictionary<string, int>();

        for (int i = 0; i < textLinesCount; i++)
        {
            string currentLine = Console.ReadLine().ToLower();
            for (int index = 0; index < currentLine.Length; index++)
            {
                textToSearchIn.Append(currentLine[index]);
                foreach (var stringToFind in substrings)
                {
                    var currentStringToFInd = stringToFind.ToString().ToLower();
                    if (textToSearchIn.ToString().EndsWith(currentStringToFInd))
                    {
                        if (!substringOccurances.ContainsKey(stringToFind.ToString()))
                        {
                            substringOccurances[stringToFind.ToString()] = 0;
                        }

                        substringOccurances[stringToFind.ToString()]++;
                    }
                }
            }
        }

        //for (int index = 0; index < substrings.Length; index++)
        //{
        //    string currentSubstringToSearch = substrings[index].ToString();
        //    textToSearchIn.
        //    //int occuranes = textToSearchIn.CountWhere(s =>  == currentSubstringToSearch);

        //    if (! substringOccurances.ContainsKey(currentSubstringToSearch))
        //    {
        //        substringOccurances[currentSubstringToSearch] = occuranes;
        //    }

        //    //substringOccurances[currentSubstringToSearch]++;
        //}

        foreach (var stringCountPair in substringOccurances)
        {
            Console.WriteLine("{0} -> {1}", stringCountPair.Key, stringCountPair.Value);
        }
    }
}