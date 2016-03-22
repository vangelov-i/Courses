namespace _06CountSymbols
{
    using System;
    using System.Linq;

    class CountSymbols
    {
        static void Main()
        {
            string inputLine = Console.ReadLine();

            char[] uniqueCharsLine = inputLine.Distinct().OrderBy(c => c).ToArray();

            for (int currentChar = 0; currentChar < uniqueCharsLine.Length; currentChar++)
            {
                int currentCharCount = 0;

                for (int currentOccurance = inputLine.IndexOf(uniqueCharsLine[currentChar]); 
                    currentOccurance > -1; 
                    currentOccurance = inputLine.IndexOf(inputLine[currentOccurance], currentOccurance + 1))
                {
                    currentCharCount++;
                }

                Console.WriteLine("{0}: {1} time/s",uniqueCharsLine[currentChar], currentCharCount);
            }
        }
    }
}