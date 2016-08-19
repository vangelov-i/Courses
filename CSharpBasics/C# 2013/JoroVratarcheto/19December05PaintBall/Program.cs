using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 14:35 - 15:15  80/100  // - 15:25 - 90/100 
class Program
{
    static void Main(string[] args)
    {
        checked
        {

            int[,] matrix = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matrix[i, j] = 1;
                }
            }
            int counter = 0;
            while (true)
            {
                string input = Console.ReadLine();
                counter++;
                if (input != "End")
                {
                    int row = int.Parse(input[0].ToString());
                    int column = 9 - int.Parse(input[2].ToString());
                    int radius = int.Parse(input[4].ToString());
                    if (input.Length > 5)
                    {
                        radius = 10;
                    }
                    int areaSide = 2 * radius + 1;



                    int bordersI = areaSide + (row - radius);
                    if (bordersI > 10)
                    {
                        bordersI = 10;
                    }
                    int bordersJ = areaSide + column - radius;
                    if (bordersJ > 10)
                    {
                        bordersJ = 10;
                    }

                    for (int i = row - radius; i < bordersI; i++)
                    {
                        if (i < 0)
                        {
                            i = 0;
                        }
                        for (int j = column - radius; j < bordersJ; j++)
                        {
                            if (j < 0)
                            {
                                j = 0;
                            }
                            if (counter % 2 !=0)
                            {
                                matrix[i, j] = 0;
                            }
                            else
                            {
                                matrix[i, j] = 1;
                            }
                        }
                    }

                }
                else
                {
                    break;
                }
            }

            int sum = 0;
            string binary = string.Empty;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    binary += matrix[i, j];
                }
                sum += Convert.ToInt32(binary, 2);
                binary = string.Empty;
            }
            Console.WriteLine(sum);

        }
    }
}