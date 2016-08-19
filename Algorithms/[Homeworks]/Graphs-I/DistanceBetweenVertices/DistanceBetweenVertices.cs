using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*  
    Znam, che prashtam pochti 3 zadachi, no imam molba da me pojalish :D 
    poneje navaksvam sega, che tezi dni imah izpit na java, zashtita na 2
    ekipni proekta, mentorska grupa iii neshto se okaza, che ne sym superman,
    ta ne smognah i s algoritmite, no sega navaksvam. Iskam da si resha vsichki 
    domashni sam i tova pravq sega. Taka che bih bil mnogo blagodaren, ako udarish 
    edno ramo za izpita, che taka i taka shte e dosta tegavo, pone da ne se drypna 
    nazad i s tezi 5 tochki ot domashnite. I, ako vse oshte chetesh :D , veche po 
    samata zadacha- ako imash komentari, preporyki, zabelejki kym jalkata mi imitaciq 
    na Dijkstra, bih go ocenil :D.
    Mersi za razbiraneto ili nerazbiraneto :D Uspeh!

    P.S. cheta input-a ot consolata, taka che copy-paste-ni inputite ot domashnoto, kato
    dobavish "end" na posledniq red, za da prekrati cheteneto
*/

class DistanceBetweenVertices
{
    static void Main()
    {
        Dictionary<int, List<int>> graph = ReadGraphFromConsole();
        StringBuilder output = new StringBuilder();

        string currentLine = Console.ReadLine();
        while (currentLine != "end")
        {
            string[] lineParams = currentLine.Split('-');
            int startNode = int.Parse(lineParams[0]);
            int targetNode = int.Parse(lineParams[1]);

            var visitedNodesDistance = new Dictionary<int, int>();
            visitedNodesDistance.Add(startNode, 0);

            Queue<int> nodesDFS = new Queue<int>();

            nodesDFS.Enqueue(startNode);
            int distance = 0;

            bool pathExists = false;
            bool nonVisitedNodesExist = nodesDFS.Count > 0;
            while (nonVisitedNodesExist && !pathExists)
            {
                int parrentNode = nodesDFS.Dequeue();
                List<int> childNodesToVisit = 
                    graph[parrentNode]
                    .Where(childNode => !visitedNodesDistance.ContainsKey(childNode))
                    .ToList();
                foreach (int childNode in childNodesToVisit)
                {
                    nodesDFS.Enqueue(childNode);

                    int childNodeDistance = visitedNodesDistance[parrentNode] + 1;
                    visitedNodesDistance.Add(childNode, childNodeDistance);

                    if (childNode == targetNode)
                    {
                        distance = childNodeDistance;
                        pathExists = true;
                        break;
                    }
                }

                nonVisitedNodesExist = nodesDFS.Count > 0;
            }

            distance = pathExists ? distance : -1;
            output.AppendLine($"{{{startNode}, {targetNode}}} -> {distance}");

            currentLine = Console.ReadLine();
        }

        Console.Write("{0}{1}", Environment.NewLine, output);
    }

    private static Dictionary<int, List<int>> ReadGraphFromConsole()
    {
        Console.ReadLine();
        var result = new Dictionary<int, List<int>>();

        string currentLine = Console.ReadLine();
        while (currentLine != "Distances to find:")
        {
            int parentNode = int.Parse(currentLine.Substring(0, currentLine.IndexOf(' ')));
            List<int> childNodes = ParseChildNodes(currentLine);
            result[parentNode] = childNodes;

            currentLine = Console.ReadLine();
        }

        return result;
    }

    private static List<int> ParseChildNodes(string currentLine)
    {
        int firstSpaceIndex = currentLine.IndexOf(' ');
        int currentNode = int.Parse(currentLine.Substring(0, firstSpaceIndex));

        int secondSpaceIndex = currentLine.IndexOf(' ', firstSpaceIndex + 1);
        string childNodes = string.Empty;

        bool childNodesExist = secondSpaceIndex >= 0;
        if (childNodesExist)
        {
            childNodes = currentLine.Substring(secondSpaceIndex);
        }

        List<int> result =
            childNodes
            .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToList();

        return result;
    }
}