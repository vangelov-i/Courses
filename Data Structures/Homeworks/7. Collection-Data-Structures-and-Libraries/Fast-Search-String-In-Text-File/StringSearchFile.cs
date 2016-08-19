using System;
using System.Collections.Generic;
using System.IO;

using Tup.AhoCorasick;

class StringSearchFile
{
    public static void Main()
    {

        string text = File.ReadAllText("../../text.txt").ToLower();
        int wordsCount = int.Parse(Console.ReadLine());
        string[] wordsOriginal = new string[wordsCount];
        string[] wordsLowerCase = new string[wordsCount];
        for (int i = 0; i < wordsCount; i++)
        {
            wordsOriginal[i] = Console.ReadLine();
            wordsLowerCase[i] = wordsOriginal[i].ToLower();
        }

        var occurances = new Dictionary<string, int>(wordsCount);
        foreach (string word in wordsLowerCase)
        {
            occurances[word] = 0;
        }

        var start = DateTime.Now;

        var search = new AhoCorasickSearch();
        var matches = search.SearchAll(text, wordsLowerCase);
        foreach (var match in matches)
        {
            string word = match.Match;
            occurances[word]++;
        }


        foreach (var wordOccurances in occurances)
        {
            Console.WriteLine("{0} -> {1}", wordOccurances.Key, wordOccurances.Value);
        }

        Console.WriteLine(DateTime.Now - start);
    }
}