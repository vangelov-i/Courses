namespace Event_reformatted
{
    using System;
    using System.Text;

    public class Event : IComparable
    {
        private readonly string location;

        private readonly string title;

        private DateTime date;

        public Event(DateTime date, string title, string location)
        {
            this.date = date;
            this.title = title;
            this.location = location;
        }

        public int CompareTo(object obj)
        {
            Event other = obj as Event;
            int orderByDate = this.date.CompareTo(other.date);
            int orderByTitle = this.title.CompareTo(other.title);
            int orderByLocation = this.location.CompareTo(other.location);

            if (orderByDate == 0)
            {
                if (orderByTitle == 0)
                {
                    return orderByLocation;
                }

                return orderByTitle;
            }

            return orderByDate;
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.Append(this.date.ToString("yyyy-MM-ddTHH:mm:ss"));
            toString.Append(" | " + this.title);

            if (!string.IsNullOrEmpty(this.location))
            {
                toString.Append(" | " + this.location);
            }

            return toString.ToString();
        }
    }
}