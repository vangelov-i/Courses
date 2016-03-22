namespace StringExtentions
{
    using System;

    public class Program
    {
        private static void Main(string[] args)
        {
            // some testing
            string extensionsTest = "asd".CapitalizeFirstLetter();
            Console.WriteLine(extensionsTest);
            extensionsTest = "асд".ConvertCyrillicToLatinLetters();
            Console.WriteLine(extensionsTest);
            extensionsTest = "a".ToMd5Hash();
            Console.WriteLine(extensionsTest);
            extensionsTest = "input".GetStringBetween(string.Empty, "u", 1);
            Console.WriteLine(extensionsTest);
            extensionsTest = "валидирай това име!%$@".ToValidUsername();
            Console.WriteLine(extensionsTest);
            extensionsTest = "aide de".GetFirstCharacters(3);
            Console.WriteLine(extensionsTest);
            extensionsTest = "asdad.mpeg".GetFileExtension();
            Console.WriteLine(extensionsTest);
        }
    }
}