using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
// 14:29 - 15:02 -> 50/100 + 30 min ->  100  // 1 hour
class Program
{
    static void Main(string[] args)
    {
        checked
        {

            decimal payment = decimal.Parse(Console.ReadLine()) * 1.94m;

            string[] teams = { "Arsenal", "Chelsea", "Everton", "Liverpool", "ManchesterCity", "ManchesterUnited", "Southampton", "Tottenham" };
            Dictionary<string, long> table = new Dictionary<string, long>()
                {
                    {teams[0], 0},
                    {teams[1], 0},
                    {teams[2], 0},
                    {teams[3], 0},
                    {teams[4], 0},
                    {teams[5], 0},
                    {teams[6], 0},
                    {teams[7], 0} 
                };

            decimal sumPayment = 0m;
            while (true)
            {
                // wtf is the next line?!
                string str = string.Join(" ", (Console.ReadLine().Split(default(string[]), StringSplitOptions.RemoveEmptyEntries)));
                //string temp = Console.ReadLine();
                //temp = temp.Replace(" ", string.Empty);
                //temp = temp.Replace("X", " X ");
                //temp = temp.Replace("1", " 1 ");
                //temp = temp.Replace("2", " 2 ");

                string[] input = str.Split(' ');
                if (input[0] == "End")
                {
                    break;
                }

                sumPayment += payment;

                if (input[1] == "1")
                {
                    table[input[0]] += 3;
                }
                else if (input[1] == "X")
                {
                    table[input[0]] += 1;
                    table[input[2]] += 1;
                }

                if (input[1] == "2")
                {
                    table[input[2]] += 3;
                }

            }

            string[] OutTeams = { "Arsenal", "Chelsea", "Manchester City", "Manchester United", "Liverpool", "Everton", "Southampton", "Tottenham" };
            Array.Sort(OutTeams);
            Console.WriteLine("{0:F2}lv.", sumPayment);
            for (int i = 0; i < OutTeams.Length; i++)
            {
                Console.WriteLine("{0} - {1} points.", OutTeams[i], table[teams[i]]);
            }

        }
    }
}