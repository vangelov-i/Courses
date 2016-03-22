namespace SimpleLogger.Models
{
    using System;

    using SimpleLogger.Interfaces;

    class SimpleLayout : ILayout
    {
        public string Format(string message, ReportLevel reportLevel, DateTime date)
        {
            string result = string.Format($"{date} - {reportLevel} - {message}");

            return result;
        }
    }
}