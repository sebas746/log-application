using NLog;

namespace LogApplication.Core.Logger
{
    public class LoggerError : ILoggerStrategy
    {
        static ILogger _logger = LogManager.GetCurrentClassLogger();
        public LoggerError()
        {
        }

        public void LogMessage(string message)
        {
            _logger.Error(message);
        }
    }
}
