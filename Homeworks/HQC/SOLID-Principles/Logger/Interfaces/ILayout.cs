namespace SimpleLogger.Interfaces
{
    using System;

    public interface ILayout
    {
        string Format(string message, ReportLevel reportLevel, DateTime date);
    }
}
