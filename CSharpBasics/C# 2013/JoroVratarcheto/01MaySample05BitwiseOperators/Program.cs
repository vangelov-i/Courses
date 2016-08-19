using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//12:35 - 13:05

class Program
{
    static void Main(string[] args)
    {


        long n = long.Parse(Console.ReadLine());
        long number = 0L;

        string binary = string.Empty;

        long inversedN = 0L;
        long reversedN = 0L;
        long newNumber = 0L;
        char[] arrayBinary = new char[] {};

        for (int i = 0; i < n; i++)
        {
            number = long.Parse(Console.ReadLine());
            binary = Convert.ToString(number, 2);
            inversedN = number ^ (long)(Math.Pow(2, binary.Length) - 1);
            arrayBinary = binary.ToArray();
            Array.Reverse(arrayBinary);
            binary = new string(arrayBinary);
            reversedN = Convert.ToInt32(binary, 2);
            newNumber = (number ^ inversedN) & reversedN;
            Console.WriteLine(newNumber);
        }
    }
}
