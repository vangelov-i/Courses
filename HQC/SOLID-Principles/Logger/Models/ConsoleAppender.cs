namespace SimpleLogger.Models
{
    using System;

    using SimpleLogger.Interfaces;

    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout)
            : base(layout)
        {
        }

        public ConsoleAppender()
        {
        }

        public override void Append(string message, ReportLevel reportLevel, DateTime date)
        {
            string output = this.Layout.Format(message, reportLevel, date);

            Console.WriteLine(output);
        }
    }
}