using System;

//Write a program that enters 5 numbers (given in a single line,
//separated by a space), calculates and prints their sum. Examples:

//numbers	    sum		numbers	        sum		numbers	            sum
//1 2 3 4 5	    15		10 10 10 10 10	50		1.5 3.14 8.2 -1 0	11.84


namespace _07SumOf5Numbers
{
    class SumOf5Numbers
    {
        static void Main(string[] args)
        {
            string strInput = Console.ReadLine();
            string[] array = strInput.Split(' ');

            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += double.Parse(array[i]);
            }
            Console.WriteLine(sum);
        }
    }
}
