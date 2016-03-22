namespace _07Phonebook
{
    using System;
    using System.Collections.Generic;

    // TODO: make this work with multiple phone numbers per person
    class Phonebook
    {
        static void Main()
        {
            string inputLine = Console.ReadLine();
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (inputLine != "search")
            {
                string[] parameters = inputLine.Split('-');

                string name = parameters[0];
                string number = parameters[1];

                if (!phonebook.ContainsKey(name))
                {
                    phonebook[name] = number;
                }

                inputLine = Console.ReadLine();
            }

            while (true)
            {
                inputLine = Console.ReadLine();
                if (string.IsNullOrEmpty(inputLine))
                {
                    break;
                }

                if (!phonebook.ContainsKey(inputLine))
                {
                    Console.WriteLine("Contact {0} does not exist.", inputLine);
                    continue;
                }

                Console.WriteLine("{0} -> {1}", inputLine, phonebook[inputLine]);
            }
        }
    }
}