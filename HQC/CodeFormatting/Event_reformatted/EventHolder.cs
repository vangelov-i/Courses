namespace Event_reformatted
{
    using System;

    public class EventHolder
    {
        private readonly OrderedBag<Event> dateOrder = new OrderedBag<Event>();

        private readonly MultiDictionary<string, Event> titleOrder = new MultiDictionary<string, Event>(true);

        public void AddEvent(DateTime date, string title, string location)
        {
            Event newEvent = new Event(date, title, location);
            this.titleOrder.Add(title.ToLower(), newEvent);
            this.dateOrder.Add(newEvent);
            Messages.EventAdded();
        }

        public void DeleteEvents(string titleToDelete)
        {
            string title = titleToDelete.ToLower();

            int removed = 0;
            foreach (var eventToRemove in this.titleOrder[title])
            {
                removed++;
                this.dateOrder.Remove(eventToRemove);
            }

            this.titleOrder.Remove(title);

            Messages.EventDeleted(removed);
        }

        public void ListEvents(DateTime date, int count)
        {
            OrderedBag<Event>.View eventsToShow = this.dateOrder.RangeFrom(
                new Event(date, string.Empty, string.Empty), 
                true);

            int showed = 0;
            foreach (var eventToShow in eventsToShow)
            {
                if (showed == count)
                {
                    break;
                }

                Messages.PrintEvent(eventToShow);
                showed++;
            }

            if (showed == 0)
            {
                Messages.NoEventsFound();
            }
        }
    }
}