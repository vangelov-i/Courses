using System;

//You are given n integers (given in a single line, separated by a space). 
//Write a program that checks whether the product of the odd elements is 
//equal to the product of the even elements. Elements are counted from 1 to n, 
//so the first element is odd, the second is even, etc. Examples:

//numbers	    result
//2 1 1 6 3	    yes
//              product = 6
//3 10 4 6 5 1	yes
//              product = 60
//4 3 2 5 2	    no
//              odd_product = 16
//              even_product = 15

class OddAndEvenProduct
{
    static void Main(string[] args)
    {
        string nums = Console.ReadLine();
        string[] arr = nums.Split(' ');

        int productOdd = 1;
        int productEven = 1;

        for (int i = 0; i < arr.Length; i++)
        {
            if (i % 2 == 0)
            {
                productOdd *= int.Parse(arr[i].ToString());
            }
            else
            {
                productEven *= int.Parse(arr[i].ToString());
            }
        }

        if (productOdd == productEven)
        {
            Console.WriteLine("Yes. Product = {0}", productEven);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("odd_product = {0}", productOdd);
            Console.WriteLine("even_product = {0}", productEven);
        }
    }
}
