using System;
using System.Globalization;
using System.Threading;

using Wintellect.PowerCollections;

public class EventsInGivenDateRange
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        var events = new OrderedMultiDictionary<DateTime, string>(true);
        int eventsCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < eventsCount; i++)
        {
            string[] eventParams = Console.ReadLine().Split('|');
            string eventName = eventParams[0].Trim();
            var eventTime = DateTime.Parse(eventParams[1].Trim());
            events.Add(eventTime, eventName);
        }

        int rangesCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < rangesCount; i++)
        {
            string[] timeParams = Console.ReadLine().Split('|');
            var startTime = DateTime.Parse(timeParams[0].Trim());
            var endTime = DateTime.Parse(timeParams[1].Trim());

            var filteredEvents = events.Range(startTime, true, endTime, true);
            Console.WriteLine(filteredEvents.Values.Count);
            foreach (var timeEventsPair in filteredEvents)
            {
                foreach (string eventName in timeEventsPair.Value)
                {
                    Console.WriteLine("{0} | {1}", eventName, timeEventsPair.Key);
                }
            }
        }
    }
}