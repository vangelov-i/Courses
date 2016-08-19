using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7SumOf5Numbers2nd
{
    class P72ndSolving
    {
        static void Main(string[] args)
        {
            //string s = "there is a cat";
            //// Split string on spaces.
            //// ... This will separate all the words.
            //string[] words = s.Split(' ');
            //foreach (string word in words)
            //{
            //    Console.WriteLine(word);
            //}
            //Console.Write("Please enter 5 numbers separeted by space (\" \"): ");
            //string numbers = Console.ReadLine();
            //string[] sepNumbers = numbers.Split(' ', ',');
            //foreach (string number in sepNumbers) 
            //Console.WriteLine(number);
            //int sum = int.Parse(sepNumbers[0] + int.Parse(sepNumbers[1]) + int.Parse(sepNumbers[2]) + int.Parse(sepNumbers[3]) + int.Parse(sepNumbers[4]));
            //Console.WriteLine(sum);
            //int firstNum = int.Parse(sepNumbers[0]);
            //int secondNum = int.Parse(sepNumbers[1]);
            //int thirdNum = int.Parse(sepNumbers[2]);
            //int fourthNum = int.Parse(sepNumbers[3]);
            //int fifthNum = int.Parse(sepNumbers[4]);
            //Console.WriteLine(firstNum + secondNum + thirdNum + fourthNum + fifthNum);
            // var intArr =  "12345678".Select(c => (int)(c-'0')).ToArray();  
            string line = Console.ReadLine() ;
            string[] numbers = line.Split(' ');
            int[] intArr = numbers.Select(n => int.Parse(n)).ToArray();
            int sum = intArr.Sum();
            Console.WriteLine(sum);

            // Chek again line 37 and understand it!

               
        }
    }
}
