using System;
using System.Collections.Generic;
using System.Linq;

class TaskScheduling
{
    static void Main()
    {
        int tasksCount = int.Parse(Console.ReadLine());
        
        HashSet<Tuple<int,int>> started = new HashSet<Tuple<int, int>>();
        var tasks = new List<Tuple<int, int>>();
        for (int i = 0; i < tasksCount; i++)
        {
            int[] lineParams = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int deadline = lineParams[0];
            int minutesNeeded = lineParams[1];

            tasks.Add(new Tuple<int, int>(deadline, minutesNeeded));
        }

        var workingCopy = tasks.OrderBy(t => t.Item1).ThenBy(t => t.Item2).ToList();
        var searchCollection = new Dictionary<int, int>();
        int totalTime = 0;

        for (int i = 0; i < tasks.Count; i++)
        {
            totalTime += workingCopy[i].Item2;
            int indexInTasks = tasks.IndexOf(workingCopy[i]);
            searchCollection.Add(i, indexInTasks);
        }

        var finishedTime = new int[tasks.Count];

        for (int minute = 1; minute <= totalTime; minute++)
        {
            var currentTask = workingCopy.FirstOrDefault(t => !started.Contains(t));
            //if (currentTask != null)
            //{
            //    started.Remove(currentTask);
            //}
            //else
            //{
                currentTask = workingCopy.FirstOrDefault(t => t.Item2 > 0);
            //}

            int deadline = currentTask.Item1;
            int minutesLeft = currentTask.Item2 - 1;
            var updatedTask = new Tuple<int, int>(deadline, minutesLeft);
            int indexInCopy = workingCopy.IndexOf(currentTask);
            workingCopy[indexInCopy] = updatedTask;

            started.Add(updatedTask);

            if (updatedTask.Item2 == 0)
            {
                finishedTime[searchCollection[indexInCopy]] = minute;
            }
        }

        for (int i = 0; i < tasks.Count; i++)
        {
            var currentTask = tasks[i];

            Console.WriteLine((i + 1) + ": " + (finishedTime[i] - currentTask.Item1));

        }
    }
}