using System;

//Write a program that generates and prints all possible cards 
//from a standard deck of 52 cards (without the jokers). The cards 
//should be printed using the classical notation (like 5♠, A♥, 9♣ and K♦). 
//The card faces should start from 2 to A. Print each card face in its four 
//possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops 
//and a switch-case statement.

//output
//2♣ 2♦ 2♥ 2♠
//3♣ 3♦ 3♥ 3♠
//…
//K♣ K♦ K♥ K♠
//A♣ A♦ A♥ A♠

class PrintADeck
{
    static void Main(string[] args)
    {
        char[] array = { '\u2660', '\u2665', '\u2666', '\u2663' };
        for (int i = 2; i <= 14; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (i < 11)
                {
                    Console.Write("{0}{1} ", i, array[j]);
                }
                switch (i)
                {
                    case 11:
                        Console.Write("J{0} ", array[j]);
                        break;
                    case 12:
                        Console.Write("Q{0} ", array[j]);
                        break;
                    case 13:
                        Console.Write("K{0} ", array[j]);
                        break;
                    case 14:
                        Console.Write("A{0} ", array[j]);
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}
