namespace _08UseYourChains
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class UseYourChains
    {
        public static void Main()
        {
            Stream inStream = Console.OpenStandardInput(1024);
            Console.SetIn(new StreamReader(inStream, Console.InputEncoding, false, 1024)); 

            string input = Console.ReadLine();
            var matches = Regex.Matches(input, @"(?<=<p>)(.*?)(?=<\/p>)");

            var filtered = new StringBuilder(string.Join(string.Empty, matches.Cast<Match>().Select(s => s.Value)));
            filtered = new StringBuilder(Regex.Replace(filtered.ToString(), "[^a-z0-9]", " "));

            for (int i = 0; i < filtered.Length; i++)
            {
                if (char.IsLetter(filtered[i]))
                {
                    if (filtered[i] <= 'm')
                    {
                        filtered[i] = (char)(filtered[i] + 13);
                    }
                    else if(filtered[i] <= 'z')
                    {
                        filtered[i] = (char)(filtered[i] - 13);
                    }
                }
            }

            filtered = new StringBuilder(Regex.Replace(filtered.ToString(), "([\\ ]+)", " "));

            Console.WriteLine(filtered);
        }
    }
}