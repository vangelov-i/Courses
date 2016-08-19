using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace P7SumOf5Numbers
{
    class SumOf5Numbers
    {
        static void Main()
        {
            //string s = "there is a cat";
            //// Split string on spaces.
            //// ... This will separate all the words.
            //string[] words = s.Split(' ');
            //foreach (string word in words)
            //{
            //    Console.WriteLine(word);
            //}
            Console.Write("Please enter 5 numbers separeted by space (\" \"): ");
            string numbers = Console.ReadLine();
            string[] sepNumbers = numbers.Split(' ' , ',');
            //foreach (string number in sepNumbers) 
            //Console.WriteLine(number);
            //int sum = int.Parse(sepNumbers[0] + int.Parse(sepNumbers[1]) + int.Parse(sepNumbers[2]) + int.Parse(sepNumbers[3]) + int.Parse(sepNumbers[4]));
            //Console.WriteLine(sum);
            int firstNum = int.Parse(sepNumbers[0]);
            int secondNum = int.Parse(sepNumbers[1]);
            int thirdNum = int.Parse(sepNumbers[2]);
            int fourthNum = int.Parse(sepNumbers[3]);
            int fifthNum = int.Parse(sepNumbers[4]);
            Console.WriteLine(firstNum + secondNum + thirdNum + fourthNum + fifthNum);
            // var intArr =  "12345678".Select(c => (int)(c-'0')).ToArray();  
        }
    }
}
