namespace Event_reformatted
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class OrderedBag<T>
    {
        public void Add(Event newEvent)
        {
            throw new NotImplementedException();
        }

        public void Remove(object eventToRemove)
        {
            throw new NotImplementedException();
        }

        public View RangeFrom(Event @event, bool b)
        {
            throw new NotImplementedException();
        }

        public class View : IEnumerable<Event>
        {
            public IEnumerator<Event> GetEnumerator()
            {
                throw new NotImplementedException();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return this.GetEnumerator();
            }
        }
    }
}