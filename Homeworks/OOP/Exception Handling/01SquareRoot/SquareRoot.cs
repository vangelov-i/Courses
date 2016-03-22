﻿using System;

//  Write a program that reads an integer number and calculates and 
//  prints its square root. If the number is invalid or negative, 
//  print "Invalid number". In all cases finally print "Good bye". 
//  Use try-catch-finally.

namespace _01SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            try
            {
                uint number = uint.Parse(Console.ReadLine());
                Console.WriteLine(Math.Sqrt(number));
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
