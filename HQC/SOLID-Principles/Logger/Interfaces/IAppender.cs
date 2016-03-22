namespace SimpleLogger.Interfaces
{
    using System;

    public interface IAppender
    {
        ILayout Layout { get; set; }

        void Append(string message, ReportLevel reportLevel, DateTime date);
    }
}
