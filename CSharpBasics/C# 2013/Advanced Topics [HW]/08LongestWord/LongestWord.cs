using System;

//Write a program to find the longest word in a text. Examples:

//Input	                                        Output

//Welcome to the Software University.	        University

//The C# Basics course is awesome start in 
//programming with C# and Visual Studio.	    programming

class LongestWord
{
    static void Main(string[] args)
    {

        string[] text = Console.ReadLine().Split(' ', '.', ',', '!', '?', ':', ';');

        string longestWord = string.Empty;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i].Length > longestWord.Length)
            {
                longestWord = text[i];
            }
        }
        Console.WriteLine(longestWord);
    }
}