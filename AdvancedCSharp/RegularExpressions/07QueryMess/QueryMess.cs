namespace _07QueryMess
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class QueryMess
    {
        static void Main()
        {
            string currentLine = Console.ReadLine();

            while (currentLine != "END")
            {

                var regex = new Regex(@"(?<=^|[\&\?])(.*?)\=(.*?)(?=[&\?]|$)");
                var matches = regex.Matches(currentLine);

                currentLine = string.Join("&", matches.Cast<Match>().Select(x => x.Value));

                currentLine = currentLine.Replace('+', ' ');
                currentLine = currentLine.Replace("%20", " ");

                currentLine = Regex.Replace(currentLine, "([\\ ]+)", " ");

                string[] pairs = currentLine.Split('&','?').Where(s => s.Contains('=')).ToArray();
                var outputDict = new Dictionary<string, List<string>>();

                for (int i = 0; i < pairs.Length; i ++)
                {
                    string[] splittedPair = pairs[i].Split('=');
                    string field = splittedPair[0].Trim();
                    string value = splittedPair[1].Trim();

                    if (!outputDict.ContainsKey(field))
                    {
                        outputDict[field] = new List<string>();
                    }

                    outputDict[field].Add(value);
                }

                foreach (var pair in outputDict)
                {
                    Console.Write("{0}=[{1}]", pair.Key, string.Join(", ", pair.Value));
                }

                Console.WriteLine();

                currentLine = Console.ReadLine();
            }
        }
    }
}