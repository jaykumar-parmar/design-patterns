namespace factorypatterndemo
{
    public class AbstractFactoryDemo
    {

        public string DbLogger()
        {
            var logger = new DbLoggerFactory().CreateLogger();
            return logger.log("logged !");
        }

        public string FileLogger()
        {
            var logger = new FileLoggerFactory().CreateLogger();
            return logger.log("logged !");
        }
    }

     public interface ILogger
    {
        string log(string logMessage);
    }

    public class DbLogger : ILogger
    {
        public string log(string logMessage)
        {
            return $"DbLogger logged : {logMessage}";
        }
    }

    public class FileLogger : ILogger
    {
        public string log(string logMessage)
        {
            return $"FileLogger logged : {logMessage}";
        }
    }

    public abstract class AbstractFactory
    {
        public abstract ILogger CreateLogger();
    }

    public class FileLoggerFactory : AbstractFactory
    {
        public override ILogger CreateLogger()
        {
            return new FileLogger();
        }
    }

    public class DbLoggerFactory : AbstractFactory
    {
        public override ILogger CreateLogger()
        {
            return new DbLogger();
        }
    }
}
