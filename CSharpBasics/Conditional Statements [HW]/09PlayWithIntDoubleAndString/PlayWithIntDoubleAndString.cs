using System;

//Write a program that, depending on the user’s choice, inputs 
//an int, double or string variable. If the variable is int or 
//double, the program increases it by one. If the variable is a 
//string, the program appends "*" at the end. Print the result 
//at the console. Use switch statement. 
//Example:

//program	                user	

//Please choose a type:
//1 --> int
//2 --> double
//3 --> string	            3	
//---------------------
//Please enter a string:	hello	

//hello*		


//Please choose a type:     user
//1 --> int
//2 --> double
//3 --> string	            2
//----------------------
//Please enter a double:	1.5

//2.5	

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Please enter an integer number: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(number + 1);
                break;
            case 2:
                Console.Write("Please enter a double number: ");
                double numberD = double.Parse(Console.ReadLine());
                Console.WriteLine(numberD + 1);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string word = Console.ReadLine();
                Console.WriteLine(word + "*");
                break;
        }
    }
}
