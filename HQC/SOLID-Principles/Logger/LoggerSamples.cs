namespace SimpleLogger
{
    using SimpleLogger.Interfaces;
    using SimpleLogger.Models;

    class LoggerSamples
    {
        static void Main()
        {
            //ILayout layout = new SimpleLayout();
            ILayout layout = new BracesLayout();

            // file is located in bin/Debug
            //IAppender appender = new FileAppender(layout, "SOLID-log.txt");
            //IAppender appender = new FileAppender("SOLID-log.txt");

            IAppender appender = new ConsoleAppender(layout);
            //IAppender appender = new ConsoleAppender();
            ILogger logger = new Logger(appender);

            logger.Info(string.Format("User {0} successfully registered.", "Gosho"));
            logger.Warn("Warning - missing files.");
            logger.Critical(string.Format("I am {0} and i messed it up a little bit.", "Gosho"));
            logger.Fatal(string.Format("I am {0} and I literally f*cked it up!", "Gosho"));
        }
    }
}