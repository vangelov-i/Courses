using System;
using System.Linq;

//Write a program that reads from the console a sequence of 
//n integer numbers and returns the minimal, the maximal number, 
//the sum and the average of all numbers (displayed with 2 digits 
//after the decimal point). The input starts by the number n (alone 
//in a line) followed by n lines, each holding an integer number. 
//The output is like in the examples below. Examples:

//input	output
//3     min = 1
//2     max = 5
//5     sum = 8
//1     avg = 2.67

//input	output
//2     min = -1
//-1    max = 4
//4	    sum = 3
//      avg = 1.50

class MinMaxSumAndAverageOfNNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Please enter how many numbers you will enter: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Please enter you numbers by pressing \"ENTER\" after each of them: ");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        int min = array.Min();
        int max = array.Max();
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += array[i];
        }

        double avg = (double)sum / (double)n;
        Console.WriteLine("min = {0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:F2}", avg);
    }
}
