using System;
using System.Collections.Generic;
using System.Linq;

//10:30 - 11:30  60/100  => + 10 min i edin dobaven red (91-vi) -> 100/100

class Program
{
    private static Dictionary<string, List<string>> graph;
    private static Dictionary<string, int> distances;
    private static HashSet<string> visited;

    static void Main(string[] args)
    {
        string[] people = Console.ReadLine().Substring(7)
            .Split(new[] { ' ', ',', '-' }, StringSplitOptions.RemoveEmptyEntries);

        string[] connections = Console.ReadLine().Substring(13)
            .Split(new[] { ' ', ',', '-' }, StringSplitOptions.RemoveEmptyEntries);

        graph = new Dictionary<string, List<string>>();
        distances = new Dictionary<string, int>();

        foreach (string person in people)
        {
            graph.Add(person, new List<string>());
            distances.Add(person, -1);
        }

        for (int i = 0; i < connections.Length; i += 2)
        {
            string firstPerson = connections[i];
            string secondPerson = connections[i + 1];
            graph[firstPerson].Add(secondPerson);
            graph[secondPerson].Add(firstPerson);
        }

        string[] initialReceivers = Console.ReadLine().Substring(6)
            .Split(new[] { ' ', ',', '-' }, StringSplitOptions.RemoveEmptyEntries);

        visited = new HashSet<string>();

        TraverseBFS(initialReceivers);

        int stepsCount = distances.Values.Max();
        var lastPeopleReached = distances.Keys.Where(personDistancePair => distances[personDistancePair] == stepsCount).OrderBy(s => s);

        if (visited.Count == graph.Count)
        {
            Console.WriteLine("All people reached in {0} steps", stepsCount);
            Console.WriteLine("People at last step: " + string.Join(", ", lastPeopleReached));
            return;
        }

        var peopleNotReached = graph.Keys.Where(p => !visited.Contains(p)).OrderBy(p => p);
        Console.WriteLine("Cannot reach: " + string.Join(", ", peopleNotReached));
    }

    public static void TraverseBFS(string[] receivers)
    {
        var people = new Queue<string>();

        foreach (string receiver in receivers)
        {
            distances[receiver] = 0;
            people.Enqueue(receiver);
            visited.Add(receiver);
        }

        while (people.Count != 0)
        {
            string currentPerson = people.Dequeue();

            foreach (var friend in graph[currentPerson])
            {
                if (!visited.Contains(friend))
                {
                    distances[friend] = distances[currentPerson] + 1;
                    people.Enqueue(friend);
                    visited.Add(friend);
                }
            }
        }
    }
}