using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that takes as input two lists of integers 
//and joins them. The result should hold all numbers from 
//the first list, and all numbers from the second list, 
//without repeating numbers, and arranged in increasing order. 
//The input and output lists are given as integers, separated 
//by a space, each list at a separate line. Examples:

//Input	                        Output

//20 40 10 10 30 80             10 20 25 30 40 80
//25 20 40 30 10	            

//5 4 3 2 1                     1 2 3 4 5 6
//6 3 2	                        

//1                             1
//1	                            

class JoinLists
{
    static void Main(string[] args)
    {

        string[] firstList = Console.ReadLine().Split(' ');
        string[] secondList = Console.ReadLine().Split(' ');

        List<string> nums = new List<string>(firstList);
        nums.AddRange(secondList);
        nums = nums.Distinct().ToList();
        nums.Sort();

        foreach (var num in nums)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

    }
}