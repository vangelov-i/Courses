using System;
using System.Collections.Generic;
using System.Linq;

//8:20 - 10:00  passing zero tests

class Program
{
    static void Main(string[] args)
    {
        var bridgesDict = new Dictionary<int, List<int>>(); // key = number, value = startIndex
        // int[] sequence = { 1, 3, 1, 3, 4, 4 };
        int[] sequence = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

        List<Bridge> bridges = new List<Bridge>();
        for (int i = 0; i < sequence.Length; i++)
        {
            int currentNum = sequence[i];
            if (!bridgesDict.ContainsKey(currentNum))
            {
                bridges.Add(new Bridge(currentNum, i));
                bridgesDict.Add(currentNum, new List<int>() { i });
            }
            else
            {
                int lastStartIndex = bridgesDict[currentNum].Count - 1;
                lastStartIndex = bridgesDict[currentNum][lastStartIndex];
                bridges[lastStartIndex] = new Bridge(currentNum, lastStartIndex, i);

                bridgesDict[currentNum].Add(i);
                bridges.Add(new Bridge(currentNum, i));
            }
        }

        bridges = bridges.Where(b => b.BridgeIsComplete).ToList();
        int maxBridges = 0;
        int startBridgeIndex = -1;

        for (int i = 0; i < bridges.Count; i++)
        {
            int previousMaxBridges = maxBridges;
            var currentBridge = bridges[i];
            int currentBridgesCount = 1;
            int numAtBridgeIndex = sequence[currentBridge.End];
            int currentBridgeEnd = currentBridge.End;
            int currentStartIndex = i;

            for (int j = i + 1; j < bridges.Count; j++)
            {
                var nextBridge = bridges[j];
                if (nextBridge.Start < currentBridgeEnd)
                {
                    continue;
                }

                currentBridgesCount++;
                if (maxBridges < currentBridgesCount)
                {
                    maxBridges = currentBridgesCount;
                }

                currentBridgeEnd = nextBridge.End;
            }

            if (previousMaxBridges <= maxBridges)
            {
                if (startBridgeIndex >= 0 && previousMaxBridges == maxBridges)
                {
                    if (bridges[startBridgeIndex].End > bridges[i].End)
                    {
                        startBridgeIndex = i;
                    }
                }
                else
                {
                    startBridgeIndex = i;
                }
            }

            if (maxBridges == 0)
            {
                maxBridges = 1;

                if (startBridgeIndex >= 0)
                {
                    if (bridges[startBridgeIndex].End > bridges[i].End)
                    {
                        startBridgeIndex = i;
                    }
                }
                else
                {
                    startBridgeIndex = i;
                }
            }

        }

        if (maxBridges == 0)
        {
            Console.WriteLine("No bridges found");
            string result = "X ";
            for (int i = 0; i < sequence.Length; i++)
            {
                Console.Write(result);
            }
            Console.WriteLine();
            return;
        }
        //var resultBridges = new List<Bridge>();

        var startBridge = bridges[startBridgeIndex];
        int currentEnd = startBridge.End;
        // resultBridges.Add(startBridge);

        HashSet<int> indexies = new HashSet<int>();
        indexies.Add(startBridge.Start);
        indexies.Add(startBridge.End);

        for (int j = startBridgeIndex + 1; j < bridges.Count; j++)
        {
            var nextBridge = bridges[j];
            if (nextBridge.Start < currentEnd)
            {
                continue;
            }

            indexies.Add(nextBridge.Start);
            indexies.Add(nextBridge.End);

            // resultBridges.Add(nextBridge);
            currentEnd = nextBridge.End;
        }

        if (maxBridges == 1)
        {
            Console.WriteLine("1 bridge found");
        }
        else
        {
            Console.WriteLine("{0} bridges found", maxBridges);
        }

        for (int i = 0; i < sequence.Length; i++)
        {
            if (indexies.Contains(i))
            {
                Console.Write(sequence[i] + " ");
            }
            else
            {
                Console.Write("X ");
            }
        }
        Console.WriteLine();
    }
}

class Bridge
{
    public Bridge(int name, int start, int end = int.MaxValue)
    {
        this.Name = name;
        this.Start = start;
        this.End = end;
    }

    public int Name { get; set; }

    public int Start { get; set; }

    public int End { get; set; }

    public bool BridgeIsComplete => this.End != int.MaxValue;

    public override string ToString()
    {
        return this.Name + " S:" + this.Start + " E:" + this.End + " " + this.BridgeIsComplete;
    }
}