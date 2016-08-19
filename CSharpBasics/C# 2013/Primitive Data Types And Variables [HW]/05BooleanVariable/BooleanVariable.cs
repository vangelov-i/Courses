using System;

namespace _05BooleanVariable
{
    class BooleanVariable
    {
        static void Main()
        {
            //Declare a Boolean variable called isFemale 
            //and assign an appropriate value corresponding 
            //to your gender. Print it on the console.	

            char gender = 'm';
            bool isFemale = gender == 'f' || gender == 'F';
            Console.WriteLine(isFemale);

        }
    }
}
