using System;

namespace _09.PlayWithIntDoubleString
{
    class Program
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
}
