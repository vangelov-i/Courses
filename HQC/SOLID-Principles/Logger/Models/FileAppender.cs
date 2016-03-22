namespace SimpleLogger.Models
{
    using System;
    using System.IO;

    using SimpleLogger.Interfaces;

    class FileAppender : Appender
    {
        private string path;

        public FileAppender(ILayout layout, string path)
            : base(layout)
        {
            this.Path = path;
        }

        public FileAppender(string path)
            : this(new SimpleLayout(), path)
        {
        }

        public string Path
        {
            get
            {
                return this.path;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Path cannot be null or empty.");
                }
                this.path = value;
            }
        }

        public override void Append(string message, ReportLevel reportLevel, DateTime date)
        {
            string output = this.Layout.Format(message, reportLevel, date);
            StreamWriter writer = new StreamWriter(this.Path, true);
            writer.WriteLine(output);
            writer.Close();
        }
    }
}