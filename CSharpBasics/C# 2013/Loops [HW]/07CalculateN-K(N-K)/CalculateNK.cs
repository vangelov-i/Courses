using System;

//In combinatorics, the number of ways to choose k different members 
//out of a group of n different elements (also known as the number of 
//combinations) is calculated by the following formula:
//For example, there are 2598960 ways to withdraw 5 cards out of a 
//standard deck of 52 cards. Your task is to write a program that 
//calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
//Try to use only two loops. Examples:

//n	    k	n! / (k! * (n-k)!)
//3	    2	3
//4	    2	6
//10 	6	210
//52	5	2598960

class CalculateNK
{
    static void Main(string[] args)
    {
        Console.Write("Please enter an integer number \"n\" where 1 < n < 100 : ");
        double n = double.Parse(Console.ReadLine());
        Console.Write("Please enter an integer number \"k\" where 1 < k < n : ");
        double k = double.Parse(Console.ReadLine());
        double difference = n - k;
        double nFac = 1;
        double kFac = 1;
        double diffFac = 1;

        for (int i = 1; i <= n; i++)
        {
            nFac *= i;
            if (i <= k)
            {
                kFac *= i;
            }
            if (i <= difference)
            {
                diffFac *= i;
            }
        }
        double combinations = nFac / (kFac * diffFac);
        Console.WriteLine("The number of possible combinations with {0} members and {1} elements is {2}", k, n, combinations);
    }
}
