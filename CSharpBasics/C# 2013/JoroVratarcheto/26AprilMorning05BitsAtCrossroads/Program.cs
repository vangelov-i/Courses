using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 12:01 - 12:47 -> 75/100  + 13 min still... // 13:40 - 14:40  /// 1hour left !! // 17:23 - 
class Program
{
    static void Main(string[] args)
    {
        checked
        {
            int n = int.Parse(Console.ReadLine());

            int[] board = new int[n];
            int crossRow = 0;
            int crossCol = 0;
            int crossCount = 0;
            int currBit = -1;
            string tempCross = string.Empty;
            List<string> crosroads = new List<string>();

            while (true)
            {

                string[] input = Console.ReadLine().Split(' ');

                if (input[0] == "end")
                {
                    break;
                }
                tempCross = input[0].ToString() + input[1];
                crosroads.Add(tempCross);
                crossCount++;
                crossRow = int.Parse(input[0].ToString());
                crossCol = int.Parse(input[1].ToString());
                int tempRow = crossRow;
                int tempCol = crossCol;
                //
                //if (input[0] == "3")
                //{
                //    Console.WriteLine();
                //}
                //
                while (tempCol > -1 && tempRow > -1)
                {
                    currBit = board[tempRow] & (1 << tempCol);
                    if (currBit != 0)
                    {
                        tempCross = tempRow.ToString() + tempCol;
                        if (crosroads.Contains(tempCross) == false)
                        {
                            crosroads.Add(tempCross);
                            crossCount++;
                        }
                    }
                    board[tempRow] = board[tempRow] | (1 << tempCol);
                    tempCol--;
                    tempRow--;
                }
                tempRow = crossRow;
                tempCol = crossCol;
                while (tempCol < n && tempRow < n)
                {
                    currBit = board[tempRow] & (1 << tempCol);
                    if (currBit != 0)
                    {
                        tempCross = tempRow.ToString() + tempCol;
                        if (crosroads.Contains(tempCross) == false)
                        {
                            crosroads.Add(tempCross);
                            crossCount++;
                        }
                    }
                    board[tempRow] = board[tempRow] | (1 << tempCol);
                    tempCol++;
                    tempRow++;
                }
                tempRow = crossRow;
                tempCol = crossCol;
                while (tempCol > -1 && tempRow < n)
                {
                    currBit = board[tempRow] & (1 << tempCol);
                    if (currBit != 0)
                    {
                        tempCross = tempRow.ToString() + tempCol;
                        if (crosroads.Contains(tempCross) == false)
                        {
                            crosroads.Add(tempCross);
                            crossCount++;
                        }
                    }
                    board[tempRow] = board[tempRow] | (1 << tempCol);
                    tempRow++;
                    tempCol--;
                }
                tempRow = crossRow;
                tempCol = crossCol;
                while (tempCol < n && tempRow > -1)
                {
                    currBit = board[tempRow] & (1 << tempCol);
                    if (currBit != 0)
                    {
                        tempCross = tempRow.ToString() + tempCol;
                        if (crosroads.Contains(tempCross) == false)
                        {
                            crosroads.Add(tempCross);
                            crossCount++;
                        }
                    }
                    board[tempRow] = board[tempRow] | (1 << tempCol);
                    tempRow--;
                    tempCol++;
                }

            }
            string temp = string.Empty;
            foreach (var num in board)
            {
                temp = Convert.ToString(num, 2);
                Console.WriteLine(Convert.ToInt64(temp,2));
            }

            //Console.WriteLine("-------------------");

            //foreach (var num in board)
            //{

            //    Console.WriteLine("{0,3}", Convert.ToString(num, 2).PadLeft(32, '0'));
            //}
            //Console.WriteLine("----------------------");
            //Console.WriteLine(crossCount);
            //if (n == 32)
            //{
            //    int a = 1;
            //    Console.WriteLine(Int32.MaxValue + a);
            //}
            //else
            //{
            crosroads = crosroads.Distinct().ToList();
            Console.WriteLine(crosroads.Count);
            //}

        }
    }
}
//test 4,5  n = 32 !!!  // test 4 crosroads.count  > 25  && < 50   // test 5  crosRoads.count  = 3 !!! 