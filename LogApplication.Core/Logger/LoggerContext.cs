namespace LogApplication.Core.Logger
{
    public class LoggerContext
    {
        readonly ILoggerStrategy _loggerStrategy;

        public LoggerContext(ILoggerStrategy loggerStrategy)
        {
            _loggerStrategy = loggerStrategy;
        }

        /// <summary>
        /// Method that implements the strategy pattern for logging.
        /// </summary>
        /// <param name="message"></param>
        public void LogMessage(string message)
        {
            _loggerStrategy.LogMessage(message);
        }
    }
}
