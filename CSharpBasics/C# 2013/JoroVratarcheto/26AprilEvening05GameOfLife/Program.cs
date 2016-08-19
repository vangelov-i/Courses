using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 12:14 - 13:44 -> 100 first time! 
class Program
{
    static void Main(string[] args)
    {
        checked
        {
            int n = int.Parse(Console.ReadLine());
            int[] board = new int[10];

            for (int i = 0; i < n; i++)
            {
                int row = int.Parse(Console.ReadLine());
                int col = int.Parse(Console.ReadLine());

                board[row] = board[row] | (1 << col);
            }

            //foreach (var item in board)
            //{
            //    Console.WriteLine(Convert.ToString(item,2).PadLeft(10,'0'));
            //}

            string position0to1 = string.Empty;
            string position1to0 = string.Empty;
            List<string> listPos0to1 = new List<string>();
            List<string> listPos1to0 = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                    int currBit = board[i] & (1 << j);
                    int up = 0;
                    int down = 0;
                    int left = 0;
                    int right = 0;
                    int leftUp = 0;
                    int rightUp = 0;
                    int leftDown = 0;
                    int rightDown = 0;
                    int neighbours = 0;
                    if (i == 0 && j == 0)
                    {
                        left = board[i] & (1 << (j + 1));
                        neighbours = (left != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        down = board[i + 1] & (1 << j);
                        neighbours = (down != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        leftDown = board[i + 1] & (1 << (j + 1));
                        neighbours = (leftDown != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        if (currBit == 0)
                        {
                            if (neighbours == 3)
                            {
                                position0to1 = i.ToString() + j;
                                listPos0to1.Add(position0to1);
                            }
                        }
                        else
                        {
                            if (neighbours < 2)
                            {
                                position1to0 = i.ToString() + j;
                                listPos1to0.Add(position1to0);
                            }
                        }
                    }
                    else if (i == 0 && j == 9)
                    {
                        right = board[i] & (1 << (j - 1));
                        neighbours = (right != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        down = board[i + 1] & (1 << j);
                        neighbours = (down != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        rightDown = board[i + 1] & (1 << (j - 1));
                        neighbours = (rightDown != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        if (currBit == 0)
                        {
                            if (neighbours == 3)
                            {
                                position0to1 = i.ToString() + j;
                                listPos0to1.Add(position0to1);
                            }
                        }
                        else
                        {
                            if (neighbours < 2)
                            {
                                position1to0 = i.ToString() + j;
                                listPos1to0.Add(position1to0);
                            }
                        }
                    }
                    else if (i == 0)
                    {
                        right = board[i] & (1 << (j - 1));
                        neighbours = (right != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        down = board[i + 1] & (1 << j);
                        neighbours = (down != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        rightDown = board[i + 1] & (1 << (j - 1));
                        neighbours = (rightDown != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        left = board[i] & (1 << (j + 1));
                        neighbours = (left != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        leftDown = board[i + 1] & (1 << (j + 1));
                        neighbours = (leftDown != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        if (currBit == 0)
                        {
                            if (neighbours == 3)
                            {
                                position0to1 = i.ToString() + j;
                                listPos0to1.Add(position0to1);
                            }
                        }
                        else
                        {
                            if (neighbours < 2 || neighbours > 3)
                            {
                                position1to0 = i.ToString() + j;
                                listPos1to0.Add(position1to0);
                            }
                        }
                    }
                    else if (i == 9 && j == 0)
                    {
                        left = board[i] & (1 << (j + 1));
                        neighbours = (left != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        up = board[i - 1] & (1 << j);
                        neighbours = (up != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        leftUp = board[i - 1] & (1 << (j + 1));
                        neighbours = (leftUp != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        if (currBit == 0)
                        {
                            if (neighbours == 3)
                            {
                                position0to1 = i.ToString() + j;
                                listPos0to1.Add(position0to1);
                            }
                        }
                        else
                        {
                            if (neighbours < 2)
                            {
                                position1to0 = i.ToString() + j;
                                listPos1to0.Add(position1to0);
                            }
                        }
                    }
                    else if (i == 9 && j == 9)
                    {
                        right = board[i] & (1 << (j - 1));
                        neighbours = (right != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        up = board[i - 1] & (1 << j);
                        neighbours = (up != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        rightUp = board[i - 1] & (1 << (j - 1));
                        neighbours = (rightUp != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        if (currBit == 0)
                        {
                            if (neighbours == 3)
                            {
                                position0to1 = i.ToString() + j;
                                listPos0to1.Add(position0to1);
                            }
                        }
                        else
                        {
                            if (neighbours < 2)
                            {
                                position1to0 = i.ToString() + j;
                                listPos1to0.Add(position1to0);
                            }
                        }
                    }
                    else if (i == 9)
                    {
                        right = board[i] & (1 << (j - 1));
                        neighbours = (right != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        up = board[i - 1] & (1 << j);
                        neighbours = (up != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        rightUp = board[i - 1] & (1 << (j - 1));
                        neighbours = (rightUp != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        left = board[i] & (1 << (j + 1));
                        neighbours = (left != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        leftUp = board[i - 1] & (1 << (j + 1));
                        neighbours = (leftUp != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        if (currBit == 0)
                        {
                            if (neighbours == 3)
                            {
                                position0to1 = i.ToString() + j;
                                listPos0to1.Add(position0to1);
                            }
                        }
                        else
                        {
                            if (neighbours < 2 || neighbours > 3)
                            {
                                position1to0 = i.ToString() + j;
                                listPos1to0.Add(position1to0);
                            }
                        }
                    }
                    else if (j == 0)
                    {
                        left = board[i] & (1 << (j + 1));
                        neighbours = (left != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        up = board[i - 1] & (1 << j);
                        neighbours = (up != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        leftUp = board[i - 1] & (1 << (j + 1));
                        neighbours = (leftUp != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        down = board[i+1] & (1 << j);
                        neighbours = (down != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        leftDown = board[i + 1] & (1 << (j + 1));
                        neighbours = (leftDown != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        if (currBit == 0)
                        {
                            if (neighbours == 3)
                            {
                                position0to1 = i.ToString() + j;
                                listPos0to1.Add(position0to1);
                            }
                        }
                        else
                        {
                            if (neighbours < 2 || neighbours > 3)
                            {
                                position1to0 = i.ToString() + j;
                                listPos1to0.Add(position1to0);
                            }
                        }
                    }
                    else if (j == 9)
                    {
                        right = board[i] & (1 << (j - 1));
                        neighbours = (right != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        up = board[i - 1] & (1 << j);
                        neighbours = (up != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        rightUp = board[i - 1] & (1 << (j - 1));
                        neighbours = (rightUp != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        down = board[i+1] & (1 << j);
                        neighbours = (down != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        rightDown = board[i + 1] & (1 << (j - 1));
                        neighbours = (rightDown != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        if (currBit == 0)
                        {
                            if (neighbours == 3)
                            {
                                position0to1 = i.ToString() + j;
                                listPos0to1.Add(position0to1);
                            }
                        }
                        else
                        {
                            if (neighbours < 2 || neighbours > 3)
                            {
                                position1to0 = i.ToString() + j;
                                listPos1to0.Add(position1to0);
                            }
                        }
                    }
                    else
                    {
                        left = board[i] & (1 << (j + 1));
                        neighbours = (left != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        leftUp = board[i - 1] & (1 << (j + 1));
                        neighbours = (leftUp != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        leftDown = board[i + 1] & (1 << (j + 1));
                        neighbours = (leftDown != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        right = board[i] & (1 << (j - 1));
                        neighbours = (right != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        up = board[i - 1] & (1 << j);
                        neighbours = (up != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        rightUp = board[i - 1] & (1 << (j - 1));
                        neighbours = (rightUp != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        down = board[i + 1] & (1 << j);
                        neighbours = (down != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);
                        rightDown = board[i + 1] & (1 << (j - 1));
                        neighbours = (rightDown != 0) ? (neighbours = neighbours + 1) : (neighbours = neighbours + 0);

                        if (currBit == 0)
                        {
                            if (neighbours == 3)
                            {
                                position0to1 = i.ToString() + j;
                                listPos0to1.Add(position0to1);
                            }
                        }
                        else
                        {
                            if (neighbours < 2 || neighbours > 3)
                            {
                                position1to0 = i.ToString() + j;
                                listPos1to0.Add(position1to0);
                            }
                        }
                    }


                }
            }

            int tempRow = 0;
            int tempCol = 0;
            for (int i = 0; i < listPos0to1.Count; i++)
            {
                tempRow = int.Parse(listPos0to1[i][0].ToString());
                tempCol = int.Parse(listPos0to1[i][1].ToString());
                board[tempRow] = board[tempRow] | (1 << tempCol);
            }
            for (int i = 0; i < listPos1to0.Count; i++)
            {
                tempRow = int.Parse(listPos1to0[i][0].ToString());
                tempCol = int.Parse(listPos1to0[i][1].ToString());
                board[tempRow] = board[tempRow] ^ (1 << tempCol);
            }

            foreach (var item in board)
            {
                Console.WriteLine(Convert.ToString(item, 2).PadLeft(10, '0'));
            }


        }
    }
}