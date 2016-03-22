namespace _08NightLife
{
    using System;
    using System.Collections.Generic;

    public class NightLife
    {
        public static void Main()
        {
            var nightLifeData = new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] parameters = command.Split(';');
                string city = parameters[0];
                string venue = parameters[1];
                string performer = parameters[2];

                if (!nightLifeData.ContainsKey(city))
                {
                    nightLifeData[city] = new SortedDictionary<string, SortedSet<string>>();
                }

                if (!nightLifeData[city].ContainsKey(venue))
                {
                    nightLifeData[city][venue] = new SortedSet<string>();
                }

                if (!nightLifeData[city][venue].Contains(performer))
                {
                    nightLifeData[city][venue].Add(performer);
                }

                command = Console.ReadLine();
            }

            foreach (KeyValuePair<string, SortedDictionary<string, SortedSet<string>>> keyValuePair in nightLifeData)
            {
                Console.WriteLine(keyValuePair.Key);

                foreach (KeyValuePair<string, SortedSet<string>> venue in keyValuePair.Value)
                {
                    Console.WriteLine("->{0}: {1}", venue.Key, string.Join(", ", venue.Value));
                }
            }
        }
    }
}