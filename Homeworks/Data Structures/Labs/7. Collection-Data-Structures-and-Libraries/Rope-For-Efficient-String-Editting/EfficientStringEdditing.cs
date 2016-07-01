using System;
using System.Linq;

using Wintellect.PowerCollections;

public class EfficientStringEdditing
{
    static void Main()
    {
        var text = new BigList<char>();

        while (true)
        {
            string commandParams = Console.ReadLine();
            if (commandParams == "PRINT")
            {
                foreach (char symbol in text)
                {
                    Console.Write(symbol);
                }

                Console.WriteLine();
                continue;
            }

            if (commandParams == "END")
            {
                break;
            }

            string commandName = commandParams.Substring(0, commandParams.IndexOf(' ')).Trim();
            char[] operand = commandParams.Substring(7).ToCharArray();

            try
            {
                switch (commandName)
                {
                    case "INSERT":
                        string[] insertParams = new string(operand).Split();
                        int insertIndex = int.Parse(insertParams[0]);
                        string textToInsert = insertParams[1];
                        text.InsertRange(insertIndex, textToInsert);
                        break;
                    case "APPEND":
                        text.AddRange(operand);
                        break;
                    case "REPLACE":
                        string[] replaceParams = new string(operand).Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);
                        int replaceIndex = int.Parse(replaceParams[0]);
                        int replaceCount = int.Parse(replaceParams[1]);
                        text.RemoveRange(replaceIndex, replaceCount);

                        string replacement = replaceParams[2];
                        text.InsertRange(replaceIndex, replacement);
                        break;
                    case "DELETE":
                        int[] deleteParams = new string(operand).Split().Select(int.Parse).ToArray();
                        int startIndex = deleteParams[0];
                        int count = deleteParams[1];
                        text.RemoveRange(startIndex, count);
                        break;
                }

                Console.WriteLine("OK");
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}