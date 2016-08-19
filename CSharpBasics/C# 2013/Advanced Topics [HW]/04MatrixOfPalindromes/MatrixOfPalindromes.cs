using System;

//Write a program to generate the following matrix of 
//palindromes of 3 letters with r rows and c columns:

class MatrixOfPalindromes
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int rows = int.Parse(input[0]);
        int cols = int.Parse(input[1]);

        for (int i = 0, k = 97; i < rows; i++, k++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write((char)((k - 97) % 26 + 97));
                Console.Write((char)(((k - 97 + j) % 26 + 97)));
                Console.Write((char)((k - 97) % 26 + 97) + " ");
            }
            Console.WriteLine();
        }

    }
}