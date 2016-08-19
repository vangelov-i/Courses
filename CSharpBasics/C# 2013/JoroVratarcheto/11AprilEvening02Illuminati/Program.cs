using System;

namespace _11AprilEvening02Illuminati
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            int counter = 0;
            int sum = 0;
            for (int i = 0; i < message.Length; i++)
            {
                if (
                    message[i] == 'A' || message[i] == 'a' ||
                    message[i] == 'E' || message[i] == 'e' ||
                    message[i] == 'I' || message[i] == 'i' ||
                    message[i] == 'O' || message[i] == 'o' ||
                    message[i] == 'U' || message[i] == 'u'
                    )
                {
                    counter++;
                    switch (message[i])
                    {
                        case 'A':
                        case 'a':
                            sum += 65;
                            break;
                        case 'E':
                        case 'e':
                            sum += 69;
                            break;
                        case 'I':
                        case 'i':
                            sum += 73;
                            break;
                        case 'O':
                        case 'o':
                            sum += 79;
                            break;
                        case 'U':
                        case 'u':
                            sum += 85;
                            break;
                        default:
                            break;
                    }
                }
            }
            Console.WriteLine(counter);
            Console.WriteLine(sum);
        }
    }
}
