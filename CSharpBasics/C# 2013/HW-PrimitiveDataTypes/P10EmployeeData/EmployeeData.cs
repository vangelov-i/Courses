using System;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main()
        {
            string firstName;
            string lastName;
            Console.WriteLine("Please enter your first name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name:");
            lastName = Console.ReadLine();

            int age;
            bool success = false;
            do
            {
                Console.WriteLine("Please enter your age:");
                age = int.Parse(Console.ReadLine());
                if (age <0 || age > 100)
                {
                    Console.WriteLine("Please enter a valid age number (0-100):");
                }
                else 
                {
                    success = true;
                }
            }
            while (!success);

            char gender;
            Console.WriteLine("Please enter your gender:");
            gender = char.Parse(Console.ReadLine());
            while (gender != 'm' && gender != 'f')
            {
                Console.WriteLine("Please enter a valid gender type (m/f):");
                gender = char.Parse(Console.ReadLine());
                //ZAEBANA ZADACHA
                //ZAEBANA ZADACHA
                //ZAEBANA ZADACHA
            }
        }
    }
}