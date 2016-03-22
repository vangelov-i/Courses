namespace SimpleLogger.Models
{
    using System;

    using SimpleLogger.Interfaces;

    public abstract class Appender : IAppender
    {
        private ILayout layout;

        protected Appender(ILayout layout)
        {
            this.Layout = layout;
        }

        protected Appender()
            : this(new SimpleLayout())
        {
        }

        public ILayout Layout
        {
            get
            {
                return this.layout;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Layout cannot be null.");
                }

                this.layout = value;
            }
        }

        public abstract void Append(string message, ReportLevel reportLevel, DateTime date);
    }
}