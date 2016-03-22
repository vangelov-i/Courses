namespace SimpleLogger.Models
{
    using System;

    using SimpleLogger.Interfaces;

    public class BracesLayout : ILayout
    {
        public string Format(string message, ReportLevel reportLevel, DateTime date)
        {
            string result = string.Format($"[{date}] ~d(^_^)b~ [{reportLevel}] ~d(^_^)b~ [{message}]");

            return result;
        }
    }
}