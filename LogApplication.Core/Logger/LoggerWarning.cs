using NLog;

namespace LogApplication.Core.Logger
{
    public class LoggerWarning : ILoggerStrategy
    {
        static ILogger _logger = LogManager.GetCurrentClassLogger();
        public LoggerWarning()
        {
        }

        public void LogMessage(string message)
        {
            _logger.Warn(message);
        }
    }
}
