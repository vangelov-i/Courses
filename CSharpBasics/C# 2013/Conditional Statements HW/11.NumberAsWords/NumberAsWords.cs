using System;

namespace _11.NumberAsWords
{
    class NumberAsWords
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int hundreds = number / 100;
            int tenths = (number - (100 * hundreds)) / 10;
            int units = number - (100 * hundreds) - (10 * tenths);
            int num11to19 = (number - (100 * hundreds)) % 100;
            string strHundred = "hundred ";
            string and = "and ";

            if (number >= 100 && number < 1000 && number % 100 != 0)
            {

                switch (hundreds)
                {
                    case 1:
                        Console.Write("one " + strHundred + and);
                        break;
                    case 2:
                        Console.Write("two " + strHundred + and);
                        break;
                    case 3:
                        Console.Write("three " + strHundred + and);
                        break;
                    case 4:
                        Console.Write("four " + strHundred + and);
                        break;
                    case 5:
                        Console.Write("five " + strHundred + and);
                        break;
                    case 6:
                        Console.Write("six " + strHundred + and);
                        break;
                    case 7:
                        Console.Write("seven " + strHundred + and);
                        break;
                    case 8:
                        Console.Write("eight " + strHundred + and);
                        break;
                    case 9:
                        Console.Write("nine " + strHundred + and);
                        break;
                }
                if (tenths != 1)
                {
                    switch (tenths)
                    {
                        case 2:
                            Console.Write("twenty ");
                            break;
                        case 3:
                            Console.Write("thirty ");
                            break;
                        case 4:
                            Console.Write("fourty ");
                            break;
                        case 5:
                            Console.Write("fifty ");
                            break;
                        case 6:
                            Console.Write("sixty ");
                            break;
                        case 7:
                            Console.Write("seventy ");
                            break;
                        case 8:
                            Console.Write("eighty ");
                            break;
                        case 9:
                            Console.Write("ninety ");
                            break;
                    }
                    if (units != 0)
                    {
                        switch (units)
                        {
                            case 1:
                                Console.WriteLine("one");
                                break;
                            case 2:
                                Console.WriteLine("two");
                                break;
                            case 3:
                                Console.WriteLine("three");
                                break;
                            case 4:
                                Console.WriteLine("four");
                                break;
                            case 5:
                                Console.WriteLine("five");
                                break;
                            case 6:
                                Console.WriteLine("six");
                                break;
                            case 7:
                                Console.WriteLine("seven");
                                break;
                            case 8:
                                Console.WriteLine("eight");
                                break;
                            case 9:
                                Console.WriteLine("nine");
                                break;
                        }
                    }
                }
                else
                {
                    switch (num11to19)
                    {
                        case 11:
                            Console.WriteLine("eleven");
                            break;
                        case 12:
                            Console.WriteLine("twelve");
                            break;
                        case 13:
                            Console.WriteLine("thirteen");
                            break;
                        case 14:
                            Console.WriteLine("fourteen");
                            break;
                        case 15:
                            Console.WriteLine("fifteen");
                            break;
                        case 16:
                            Console.WriteLine("sixteen");
                            break;
                        case 17:
                            Console.WriteLine("seventeen");
                            break;
                        case 18:
                            Console.WriteLine("eighteen");
                            break;
                        case 19:
                            Console.WriteLine("nineteen");
                            break;
                    }
                }
                
            }
            else
            {
                switch (hundreds)
                {
                    case 1:
                        Console.WriteLine("one " + strHundred);
                        break;
                    case 2:
                        Console.WriteLine("two " + strHundred);
                        break;
                    case 3:
                        Console.WriteLine("three " + strHundred);
                        break;
                    case 4:
                        Console.WriteLine("four " + strHundred);
                        break;
                    case 5:
                        Console.WriteLine("five " + strHundred);
                        break;
                    case 6:
                        Console.WriteLine("six " + strHundred);
                        break;
                    case 7:
                        Console.WriteLine("seven " + strHundred);
                        break;
                    case 8:
                        Console.WriteLine("eight " + strHundred);
                        break;
                    case 9:
                        Console.WriteLine("nine " + strHundred);
                        break;
                }
            }
            if (number > 19 && number < 100)
            {
                switch (tenths)
                {
                    case 2:
                        Console.Write("twenty ");
                        break;
                    case 3:
                        Console.Write("thirty ");
                        break;
                    case 4:
                        Console.Write("fourty ");
                        break;
                    case 5:
                        Console.Write("fifty ");
                        break;
                    case 6:
                        Console.Write("sixty ");
                        break;
                    case 7:
                        Console.Write("seventy ");
                        break;
                    case 8:
                        Console.Write("eighty ");
                        break;
                    case 9:
                        Console.Write("ninety ");
                        break;
                }
                if (units != 0)
                {
                    switch (units)
                    {
                        case 1:
                            Console.WriteLine("one");
                            break;
                        case 2:
                            Console.WriteLine("two");
                            break;
                        case 3:
                            Console.WriteLine("three");
                            break;
                        case 4:
                            Console.WriteLine("four");
                            break;
                        case 5:
                            Console.WriteLine("five");
                            break;
                        case 6:
                            Console.WriteLine("six");
                            break;
                        case 7:
                            Console.WriteLine("seven");
                            break;
                        case 8:
                            Console.WriteLine("eight");
                            break;
                        case 9:
                            Console.WriteLine("nine");
                            break;
                    }
                }
            }
            else
            {
                switch (number)
                {
                    case 0:
                        Console.WriteLine("zero");
                        break;
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.WriteLine("three");
                        break;
                    case 4:
                        Console.WriteLine("four");
                        break;
                    case 5:
                        Console.WriteLine("five");
                        break;
                    case 6:
                        Console.WriteLine("six");
                        break;
                    case 7:
                        Console.WriteLine("seven");
                        break;
                    case 8:
                        Console.WriteLine("eight");
                        break;
                    case 9:
                        Console.WriteLine("nine");
                        break;
                    case 10:
                        Console.WriteLine("ten");
                        break;
                    case 11:
                        Console.WriteLine("eleven");
                        break;
                    case 12:
                        Console.WriteLine("twelve");
                        break;
                    case 13:
                        Console.WriteLine("thirteen");
                        break;
                    case 14:
                        Console.WriteLine("fourteen");
                        break;
                    case 15:
                        Console.WriteLine("fifteen");
                        break;
                    case 16:
                        Console.WriteLine("sixteen");
                        break;
                    case 17:
                        Console.WriteLine("seventeen");
                        break;
                    case 18:
                        Console.WriteLine("eighteen");
                        break;
                    case 19:
                        Console.WriteLine("nineteen");
                        break;

                }
            }

            Console.WriteLine();



            //if (number <= 15)
            //{
            //    switch (number)
            //    {
            //        case 0:
            //            Console.WriteLine("zero");
            //            break;
            //        case 1:
            //            Console.WriteLine("one");
            //            break;
            //        case 2:
            //            Console.WriteLine("two");
            //            break;
            //        case 3:
            //            Console.WriteLine("three");
            //            break;
            //        case 4:
            //            Console.WriteLine("four");
            //            break;
            //        case 5:
            //            Console.WriteLine("five");
            //            break;
            //        case 6:
            //            Console.WriteLine("six");
            //            break;
            //        case 7:
            //            Console.WriteLine("seven");
            //            break;
            //        case 8:
            //            Console.WriteLine("eight");
            //            break;
            //        case 9:
            //            Console.WriteLine("nine");
            //            break;
            //        case 10:
            //            Console.WriteLine("ten");
            //            break;
            //        case 11:
            //            Console.WriteLine("eleven");
            //            break;
            //        case 12:
            //            Console.WriteLine("twelve");
            //            break;
            //        case 13:
            //            Console.WriteLine("thirteen");
            //            break;
            //        case 14:
            //            Console.WriteLine("fourteen");
            //            break;
            //        case 15:
            //            Console.WriteLine("fifteen");
            //            break;
            //        default:
            //            Console.WriteLine("invalid input");
            //            break;
            //    }
            //}
            //else if (number > 15)
            //{

            //}
        }
    }
}
