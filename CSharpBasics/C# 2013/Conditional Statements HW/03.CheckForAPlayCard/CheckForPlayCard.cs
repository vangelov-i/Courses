using System;

namespace _03.CheckForAPlayCard
{
    class CheckForPlayCard
    {
        static void Main()
        {
            string card = Console.ReadLine();
            if (card == "2" || card == "3" || card == "4" || card == "5" || card == "6" || card == "7" || card == "8" || card == "9" || card == "10" || card == "J" || card == "Q" || card == "K" || card == "A")
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

            // Another way to do it:

            //switch (card)
            //{
            //    case "2":
            //    case "3":
            //    case "4":
            //    case "5":
            //    case "6":
            //    case "7":
            //    case "8":
            //    case "9":
            //    case "10":
            //    case "J":
            //    case "Q":
            //    case "K":
            //    case "A":
            //        Console.WriteLine("yes");
            //        break;
            //    default: Console.WriteLine("no");
            //        break;
            //}
        }
    }
}
