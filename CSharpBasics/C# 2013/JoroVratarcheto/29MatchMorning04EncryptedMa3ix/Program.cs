using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 17:18 - 18:05  -> 100 
class Program
{
    static void Main(string[] args)
    {
        checked
        {

            string input = Console.ReadLine();
            string direction = Console.ReadLine();

            string converted = string.Empty;
            int temp = 0;
            for (int i = 0; i < input.Length; i++)
            {
                temp = (int)input[i] % 10;
                converted += temp;
            }
            temp = 0;
            string encrypted = string.Empty;
            for (int i = 0; i < converted.Length; i++)
            {
                temp = int.Parse(converted[i].ToString());
                if (i == 0)
                {
                    if (temp % 2 == 0)
                    {
                        temp *= temp;
                    }
                    else
                    {
                        if (converted.Length > 1) // 2-ri test gyrmeshe tuk zaedno sys 3-ti zero test
                        {
                            temp = int.Parse(converted[i].ToString()) + int.Parse(converted[i + 1].ToString());
                        }
                    }
                }
                else if (i < converted.Length - 1)
                {
                    if (temp % 2 == 0)
                    {
                        temp *= temp;
                    }
                    else
                    {
                        temp = int.Parse(converted[i - 1].ToString()) + int.Parse(converted[i].ToString()) + int.Parse(converted[i + 1].ToString());
                    }
                }
                else
                {
                    if (temp % 2 == 0)
                    {
                        temp *= temp;
                    }
                    else
                    {
                        temp = int.Parse(converted[i].ToString()) + int.Parse(converted[i - 1].ToString()); 
                    }
                }

                if (temp < 10)
                {
                    encrypted += temp;
                }
                else
                {
                    encrypted += (temp / 10).ToString() + (temp % 10);
                }

            }
            //Console.WriteLine(converted);
            //Console.WriteLine(encrypted);

            int[,] matrix = new int[encrypted.Length, encrypted.Length];

            if (direction == "\\")
            {
                for (int i = 0; i < encrypted.Length; i++)
                {
                    matrix[i, i] = int.Parse(encrypted[i].ToString());
                }
            }
            else
            {
                for (int i = encrypted.Length - 1; i >= 0; i--)
                {
                    int j = encrypted.Length - 1 - i;
                    matrix[i, j] = int.Parse(encrypted[j].ToString());
                }
            }

            for (int i = 0; i < encrypted.Length; i++)
            {
                for (int j = 0; j < encrypted.Length; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}