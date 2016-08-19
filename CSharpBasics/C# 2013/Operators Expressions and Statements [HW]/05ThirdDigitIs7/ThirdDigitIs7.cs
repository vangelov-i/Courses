using System;

//Write an expression that checks for given integer if 
//its third digit from right-to-left is 7. Examples:

//n	        Third digit 7?
//5	        false
//701	    true
//9703	    true
//877	    false
//777877	false
//9999799	true

namespace _05ThirdDigitIs7
{
    class ThirdDigitIs7
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            n = (n / 100)%10;
            bool isSeven = n == 7;
            Console.WriteLine(isSeven);
        }
    }
}