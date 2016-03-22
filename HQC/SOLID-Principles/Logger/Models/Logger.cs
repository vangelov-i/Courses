namespace SimpleLogger.Models
{
    using System;

    using SimpleLogger.Interfaces;

    public class Logger : ILogger
    {
        private IAppender appender;

        public Logger(IAppender appender)
        {
            this.Appender = appender;
        }

        public Logger()
            : this(new ConsoleAppender())
        {
        }

        public IAppender Appender
        {
            get
            {
                return this.appender;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Appender cannot be null.");
                }

                this.appender = value;
            }
        }

        public void Info(string message)
        {
            this.Log(message, ReportLevel.Info);
        }

        public void Warn(string message)
        {
            this.Log(message, ReportLevel.Warn);
        }

        public void Error(string message)
        {
            this.Log(message, ReportLevel.Error);
        }

        public void Critical(string message)
        {
            this.Log(message, ReportLevel.Critical);
        }

        public void Fatal(string message)
        {
            this.Log(message, ReportLevel.Fatal);
        }

        private void Log(string message, ReportLevel reportLevel)
        {
            var date = DateTime.Now;
            this.Appender.Append(message, reportLevel, date);
        }
    }
}