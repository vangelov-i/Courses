using System;

//Write a program that asks for a digit (0-9), and depending 
//on the input, shows the digit as a word (in English). Print 
//“not a digit” in case of invalid inut. Use a switch statement. 
//Examples:

//d	        result

//2	        two
//1	        one
//0	        zero
//5	        five
//-0.1	    not a digit
//hi	    not a digit
//9	nine    
//10	    not a digit

class DigitAsWord
{
    static void Main()
    {
        string input = Console.ReadLine();
        int digit = 0;
        bool isDigit = int.TryParse(input, out digit);

        if (isDigit && digit < 10 && digit >= 0)
        {
            if (digit == 0)
            {
                Console.WriteLine("zero");
            }
            else if (digit == 1)
            {
                Console.WriteLine("one");
            }
            else if (digit == 2)
            {
                Console.WriteLine("two");
            }
            else if (digit == 3)
            {
                Console.WriteLine("three");
            }
            else if (digit == 4)
            {
                Console.WriteLine("four");
            }
            else if (digit == 5)
            {
                Console.WriteLine("five");
            }
            else if (digit == 6)
            {
                Console.WriteLine("six");
            }
            else if (digit == 7)
            {
                Console.WriteLine("seven");
            }
            else if (digit == 8)
            {
                Console.WriteLine("eight");
            }
            else
            {
                Console.WriteLine("nine");
            }
        }
        else
        {
            Console.WriteLine("not a digit");
        }
    }
}
