using System;

//Write a program to find the longest area of equal elements 
//in array of strings. You first should read an integer n and 
//n strings (each at a separate line), then find and print the 
//longest sequence of equal elements (first its length, then its 
//elements). If multiple sequences have the same maximal length, 
//print the leftmost of them. Examples:

class LongestAreaInArray
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string current = string.Empty;
        string prevStr = string.Empty;
        string maxStr = string.Empty;
        int max = 1;
        int temp = 1;
        for (int i = 0; i < n; i++)
        {
            current = Console.ReadLine();
            if (current == prevStr)
            {
                temp++;
                if (i == n-1 && temp > max)
                {
                    maxStr = prevStr;
                    max = Math.Max(max, temp);
                }
            }
            else
            {
                if (temp > max)
                {
                    maxStr = prevStr;
                }
                max = Math.Max(max, temp);
                temp = 1;
            }
            prevStr = current;
            if (i == 0)
            {
                maxStr = current;
            }
        }
        Console.WriteLine();
        
        //OUTPUT:

        Console.WriteLine(max);
        for (int i = 0; i < max; i++)
        {
            Console.WriteLine(maxStr);
        }

    }
}
