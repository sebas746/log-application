using NLog;

namespace LogApplication.Core.Logger
{
    public class LoggerInfo : ILoggerStrategy
    {
        static ILogger _logger = LogManager.GetCurrentClassLogger();
        public LoggerInfo()
        {
        }

        public void LogMessage(string message)
        {
            _logger.Info(message);
        }
    }
}
