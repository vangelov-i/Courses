using System;
// 03 - Third
class Program
{
    static void Main()
    {
        checked
        {

            int people = int.Parse(Console.ReadLine());
            int chosen = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();

            int height = people * 6 + 1;
            int width = 13;

            //if (symbol == "X" || symbol == "x")
            //{
            for (int i = 0; i < people; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (j == 0)
                    {
                        Console.Write(new string('.', width));
                    }
                    else if (j == 1 || j == 5)
                    {
                        Console.Write(new string('.', 3));
                        Console.Write("+");
                        Console.Write(new string('-', 5));
                        Console.Write("+");
                        Console.Write(new string('.', 3));
                    }
                    else if (j == 2 && symbol == "x" || symbol == "X" && i +1 == chosen)
                    {
                        Console.Write(new string('.', 3));
                        Console.Write("|");
                        Console.Write(".");
                        Console.Write("\\");
                        Console.Write(".");
                        Console.Write("/");
                        Console.Write(".");
                        Console.Write("|");
                        Console.Write(new string('.', 3));
                    }
                    else if (j == 4 && symbol == "x" || symbol == "X" && i+1 == chosen)
                    {
                        Console.Write(new string('.', 3));
                        Console.Write("|");
                        Console.Write(".");
                        Console.Write("/");
                        Console.Write(".");
                        Console.Write("\\");
                        Console.Write(".");
                        Console.Write("|");
                        Console.Write(new string('.', 3));
                    }
                    else if (j == 3 && symbol == "x" || symbol == "X" && i+1 == chosen)
                    {
                        if (i < 9)
                        {
                            Console.Write("0");
                            Console.Write((i + 1) + ".");
                            Console.Write("|");
                            Console.Write(new string('.', 2));
                            Console.Write(symbol);
                            Console.Write(new string('.', 2));
                            Console.Write("|");
                            Console.Write(new string('.', 3));
                        }
                        else
                        {
                            //Console.Write("0");
                            Console.Write((i + 1) + ".");
                            Console.Write("|");
                            Console.Write(new string('.', 2));
                            Console.Write(symbol);
                            Console.Write(new string('.', 2));
                            Console.Write("|");
                            Console.Write(new string('.', 3));
                        }
                        Console.WriteLine();
                    }
                    //else
                    //{
                    //    if (j == 0)
                    //    {
                    //        Console.Write(new string('.', width));
                    //    }
                    //    else if (j == 1 || j == 5)
                    //    {
                    //        Console.Write(new string('.', 3));
                    //        Console.Write("+");
                    //        Console.Write(new string('-', 5));
                    //        Console.Write("+");
                    //        Console.Write(new string('.', 3));
                    //    }
                    //    else if ( j == 3 && i + 1 == chosen)
                    //    {
                    //        if (i < 9)
                    //        {
                    //            Console.Write("0");
                    //            Console.Write((i + 1) + ".");
                    //            Console.Write("|");
                    //            Console.Write(new string('.', 2));
                    //            Console.Write(symbol);
                    //            Console.Write(new string('.', 2));
                    //            Console.Write("|");
                    //            Console.Write(new string('.', 3));
                    //        }
                    //        else
                    //        {
                    //            //Console.Write("0");
                    //            Console.Write((i + 1) + ".");
                    //            Console.Write("|");
                    //            Console.Write(new string('.', 2));
                    //            Console.Write(symbol);
                    //            Console.Write(new string('.', 2));
                    //            Console.Write("|");
                    //            Console.Write(new string('.', 3));
                    //        }
                    //    }
                    //    else if (j == 3 && i+1 != chosen)
                    //    {
                    //        if (i < 9)
                    //        {
                    //            Console.Write("0");
                    //            Console.Write((i + 1) + ".");
                    //            Console.Write("|");
                    //            Console.Write(new string('.', 2));
                    //            Console.Write(new string('.', 3));
                    //            Console.Write("|");
                    //            Console.Write(new string('.', 3));
                    //        }
                    //        else
                    //        {
                    //            //Console.Write("0");
                    //            Console.Write((i + 1) + ".");
                    //            Console.Write("|");
                    //            Console.Write(new string('.', 2));
                    //            Console.Write(new string('.', 3));
                    //            Console.Write("|");
                    //            Console.Write(new string('.', 3));
                    //        }
                    //    }
                    //    else
                    //    {
                    //        Console.Write(new string('.', 3));
                    //        Console.Write("|");
                    //        Console.Write(new string('.', 5));
                    //        Console.Write("|");
                    //        Console.Write(new string('.', 3));
                    //    }
                    //    Console.WriteLine();
                    //}
                }
                //Console.WriteLine();

                if (i == people - 1)
                {
                    Console.WriteLine(new string('.', width));
                }
            }
            //}
            //else
            //{
            //    for (int i = 0; i < people; i++)
            //    {
            //        for (int j = 0; j < 6; j++)
            //        {
            //            if (i + 1 == chosen)
            //            {
            //                if (j == 0)
            //                {
            //                    Console.Write(new string('.', width));
            //                }
            //                else if (j == 1 || j == 5)
            //                {
            //                    Console.Write(new string('.', 3));
            //                    Console.Write("+");
            //                    Console.Write(new string('-', 5));
            //                    Console.Write("+");
            //                    Console.Write(new string('.', 3));
            //                }
            //                else if (j == 2)
            //                {
            //                    Console.Write(new string('.', 3));
            //                    Console.Write("|");
            //                    Console.Write("\\");
            //                    Console.Write("...");
            //                    Console.Write("/");
            //                    Console.Write("|");
            //                    Console.Write(new string('.', 3));
            //                }
            //                else if (j == 3)
            //                {
            //                    Console.Write(new string('.', 3));
            //                    Console.Write("|");
            //                    Console.Write(".");
            //                    Console.Write("\\");
            //                    Console.Write(".");
            //                    Console.Write("/");
            //                    Console.Write(".");
            //                    Console.Write("|");
            //                    Console.Write(new string('.', 3));
            //                }
            //                else if (j == 4 && i+1 == chosen)
            //                {
            //                    Console.Write(new string('.', 3));
            //                    Console.Write("|");
            //                    Console.Write(".");
            //                    Console.Write(".");
            //                    Console.Write(symbol);
            //                    Console.Write(".");
            //                    Console.Write(".");
            //                    Console.Write("|");
            //                    Console.Write(new string('.', 3));
            //                }
            //                else if (j == 4 && i+1 != chosen)
            //                {
            //                    Console.Write(new string('.', 3));
            //                    Console.Write("|");
            //                    Console.Write(".");
            //                    Console.Write(".");
            //                    Console.Write(".");
            //                    Console.Write(".");
            //                    Console.Write(".");
            //                    Console.Write("|");
            //                    Console.Write(new string('.', 3));
            //                }
            //                else
            //                {
            //                    if (i < 9)
            //                    {
            //                        Console.Write("0");
            //                        Console.Write((i + 1) + ".");
            //                        Console.Write("|");
            //                        Console.Write(new string('.', 2));
            //                        Console.Write(symbol);
            //                        Console.Write(new string('.', 2));
            //                        Console.Write("|");
            //                        Console.Write(new string('.', 3));
            //                    }
            //                    else
            //                    {
            //                        Console.Write((i + 1) + ".");
            //                        Console.Write("|");
            //                        Console.Write(new string('.', 2));
            //                        Console.Write(symbol);
            //                        Console.Write(new string('.', 2));
            //                        Console.Write("|");
            //                        Console.Write(new string('.', 3));
            //                    }
            //                }
            //                Console.WriteLine();
            //            }
            //            else
            //            {
            //                if (j == 0)
            //                {
            //                    Console.Write(new string('.', width));
            //                }
            //                else if (j == 1 || j == 5)
            //                {
            //                    Console.Write(new string('.', 3));
            //                    Console.Write("+");
            //                    Console.Write(new string('-', 5));
            //                    Console.Write("+");
            //                    Console.Write(new string('.', 3));
            //                }
            //                else if (j == 3 && i + 1 == chosen)
            //                {
            //                    if (i < 9)
            //                    {
            //                        Console.Write("0");
            //                        Console.Write((i + 1) + ".");
            //                        Console.Write("|");
            //                        Console.Write(new string('.', 2));
            //                        Console.Write(symbol);
            //                        Console.Write(new string('.', 2));
            //                        Console.Write("|");
            //                        Console.Write(new string('.', 3));
            //                    }
            //                    else
            //                    {
            //                        Console.Write((i + 1) + ".");
            //                        Console.Write("|");
            //                        Console.Write(new string('.', 2));
            //                        Console.Write(symbol);
            //                        Console.Write(new string('.', 2));
            //                        Console.Write("|");
            //                        Console.Write(new string('.', 3));
            //                    }
            //                }
            //                else if (j == 3 && i + 1 != chosen)
            //                {
            //                    if (i < 9)
            //                    {
            //                        Console.Write("0");
            //                        Console.Write((i + 1) + ".");
            //                        Console.Write("|");
            //                        Console.Write(new string('.', 2));
            //                        Console.Write(new string('.', 3));
            //                        Console.Write("|");
            //                        Console.Write(new string('.', 3));
            //                    }
            //                    else
            //                    {
            //                        Console.Write((i + 1) + ".");
            //                        Console.Write("|");
            //                        Console.Write(new string('.', 2));
            //                        Console.Write(new string('.', 3));
            //                        Console.Write("|");
            //                        Console.Write(new string('.', 3));
            //                    }
            //                }
            //                else
            //                {
            //                    Console.Write(new string('.', 3));
            //                    Console.Write("|");
            //                    Console.Write(new string('.', 5));
            //                    Console.Write("|");
            //                    Console.Write(new string('.', 3));
            //                }
            //                Console.WriteLine();
            //            }
            //        }
            //        if (i == people - 1)
            //        {
            //            Console.WriteLine(new string('.', width));
            //        }
            //    }
            //}
        }
    }
}