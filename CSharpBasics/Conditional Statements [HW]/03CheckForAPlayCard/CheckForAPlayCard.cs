using System;

//Classical play cards use the following signs to designate the card face: 
//2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters 
//a string and prints “yes” if it is a valid card sign or “no” otherwise. 
//Examples:

//character	    Valid card sign?
//5	            yes
//1	            no
//Q	            yes
//q	            no
//P	            no
//10	        yes
//500	        no

namespace _03CheckForAPlayCard
{
    class CheckForAPlayCard
    {
        static void Main()
        {
            string card = Console.ReadLine();
            int numFaces = 0;
            bool cardIsNum = int.TryParse(card, out numFaces);

            if (numFaces >1 && numFaces < 11 || card == "J" || card == "Q" || card == "K" || card == "A")
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
