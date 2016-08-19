using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 12:50 - 13:38  -> 75/100  + 15min -> 100
class Program
{
    static void Main(string[] args)
    {
        checked
        {

            string[] command = new string[2];
            int[] board = new int[8];
            byte currRow = 0;
            byte currCol = 0;
            board[currRow] = board[currRow] ^ (1 << currCol);

            while (true)
            {

                command = Console.ReadLine().Split(' ');
                if (command[0] ==  "stop")
                {
                    break;
                }
                else if (command[0] == "left")
                {
                    if (currCol + 2 < 8)
                    {
                        if (command[1] == "down")
                        {
                            if (currRow + 1 < 8)
                            {
                                currCol += 2;
                                currRow++;
                                board[currRow] = board[currRow] ^ (1 << currCol);
                            }
                        }
                        else
                        {
                            if (currRow - 1 > -1)
                            {
                                currCol += 2;
                                currRow--;
                                board[currRow] = board[currRow] ^ (1 << currCol);
                            }
                        }
                    }
                }
                else if (command[0] == "right")
                {
                    if (currCol - 2 > -1)
                    {
                        if (command[1] == "down")
                        {
                            if (currRow + 1 < 8)
                            {
                                currCol -= 2;
                                currRow++;
                                board[currRow] = board[currRow] ^ (1 << currCol);
                            }
                        }
                        else
                        {
                            if (currRow - 1 > -1)
                            {
                                currCol -= 2;
                                currRow--;
                                board[currRow] = board[currRow] ^ (1 << currCol);
                            }
                        }
                    }
                }
                else if (command[0] == "down")
                {
                    if (currRow + 2 < 8)
                    {
                        if (command[1] == "left")
                        {
                            if (currCol + 1 < 8)
                            {
                                currRow += 2;
                                currCol ++;
                                board[currRow] = board[currRow] ^ (1 << currCol);
                            }
                        }
                        else
                        {
                            if (currCol - 1 > -1)
                            {
                                currRow += 2;
                                currCol--;
                                board[currRow] = board[currRow] ^ (1 << currCol);
                            }
                        }
                    }
                }
                else if (command[0] == "up")
                {
                    if (currRow -2 > -1)
                    {
                        if (command[1] == "left")
                        {
                            if (currCol +1 < 8)
                            {
                                currRow -= 2;
                                currCol++;
                                board[currRow] = board[currRow] ^ (1 << currCol);
                            }
                        }
                        else
                        {
                            if (currCol -1 > -1)
                            {
                                currRow -= 2;
                                currCol--;
                                board[currRow] = board[currRow] ^ (1 << currCol);
                            }
                        }
                    }
                }

            }

            bool nonZero = false;
            foreach (var number in board)
            {
                if (number != 0)
                {
                    nonZero = true;
                    Console.WriteLine(number);
                }
            }

            if (nonZero == false)
            {
                Console.WriteLine("[Board is empty]");
            }

        }
    }
}