using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 16:11 - 16:48  70/100  + 10 min  ->  100
class Program
{
    static void Main(string[] args)
    {
        checked
        {

            string currentShooter = Console.ReadLine();
            int rounds = int.Parse(Console.ReadLine());

            int nakovP = 0;
            int simeonP = 0;
            int currRound = 0;
            bool winnerNakov = false;
            bool winnerSimeon = false;

            for (int i = 0; i < rounds; i++)
            {
                currRound = 1 + i;
                for (int j = 0; j < 2; j++)
                {
                    int pointsTry = int.Parse(Console.ReadLine());
                    string result = Console.ReadLine();
                    if (result == "success")
                    {
                        if (currentShooter == "Nakov")
                        {
                            if (nakovP + pointsTry <= 500)
                            {
                                nakovP += pointsTry;
                                if (nakovP == 500)
                                {
                                    winnerNakov = true;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            if (simeonP + pointsTry <= 500)
                            {
                                simeonP += pointsTry;
                                if (simeonP == 500)
                                {
                                    winnerSimeon = true;
                                    break;
                                }
                            }
                        }
                    }
                    if (j == 0)
                    {
                        if (currentShooter == "Nakov")
                        {
                            currentShooter = "Simeon";
                        }
                        else
                        {
                            currentShooter = "Nakov";
                        }
                    }
                }
                if (winnerNakov == true || winnerSimeon == true)
                {
                    break;
                }
            }

            if (winnerNakov)
            {
                Console.WriteLine("Nakov");
                Console.WriteLine(currRound);
                Console.WriteLine(simeonP);
            }
            else if (winnerSimeon)
            {
                Console.WriteLine("Simeon");
                Console.WriteLine(currRound);
                Console.WriteLine(nakovP);
            }
            else if (nakovP == simeonP)
            {
                Console.WriteLine("DRAW");
                Console.WriteLine(nakovP);
            }
            else
            {
                if (nakovP > simeonP)
                {
                    Console.WriteLine("Nakov");
                    Console.WriteLine(nakovP - simeonP);
                }
                else
                {
                    Console.WriteLine("Simeon");
                    Console.WriteLine(simeonP - nakovP);
                }
            }



        }
    }
}