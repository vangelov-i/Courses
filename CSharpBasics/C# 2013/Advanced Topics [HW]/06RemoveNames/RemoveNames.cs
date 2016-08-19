using System;
using System.Linq;

//Write a program that takes as input two lists of names and removes
//from the first list all names given in the second list. The input 
//and output lists are given as words, separated by a space, each 
//list at a separate line. Examples:

//Input	                                        Output
//Peter Alex Maria Todor Steve Diana Steve
//Todor Steve Nakov	                            Peter Alex Maria Diana

//Hristo Hristo Nakov Nakov Petya
//Nakov Vanessa Maria	                        Hristo Hristo Petya

class RemoveNames
{
    static void Main(string[] args)
    {
        string[] firstList = Console.ReadLine().Split(' ');
        string[] secondList = Console.ReadLine().Split(' ');

        for (int i = 0; i < secondList.Length; i++)
        {
            firstList = firstList.Where(str => str != secondList[i]).ToArray();
        }

        foreach (var name in firstList)
        {
            Console.Write(name + " ");
        }
        Console.WriteLine();
    }
}