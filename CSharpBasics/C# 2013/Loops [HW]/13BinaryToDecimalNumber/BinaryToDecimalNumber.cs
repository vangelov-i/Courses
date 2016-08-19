using System;

//Using loops write a program that converts a binary integer number 
//to its decimal form. The input is entered as string. The output 
//should be a variable of type long. Do not use the built-in .NET 
//functionality. Examples:

//binary	                    decimal
//0	                            0
//11	                        3
//1010101010101011	            43691
//1110000110000101100101000000	236476736

class BinaryToDecimalNumber
{
    static void Main(string[] args)
    {
        string binary = Console.ReadLine();
        int arrayMembers = 0;
        foreach (var item in binary)
        {
            arrayMembers++;
        }
        long[] binaryLongArray = new long[arrayMembers];

        int index = 0;
        foreach (var item in binary)
        {
            if (item == '0')
            {
                binaryLongArray[index] = 0;
            }
            else
            {
                binaryLongArray[index] = 1;
            }
            index++;
        }

        long sum = 0;
        for (int i = 0; i < binaryLongArray.Length; i++)
        {
            if (binaryLongArray[i] == 1)
            {
                sum += (long)Math.Pow(2, (arrayMembers - 1));
            }
            arrayMembers--;
        }
        Console.WriteLine(sum);
    }
}
