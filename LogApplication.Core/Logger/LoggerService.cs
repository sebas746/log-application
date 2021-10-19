using System;

namespace LogApplication.Core.Logger
{
    public class LoggerService : ILoggerService
    {
        public LoggerService()
        {
        }

        public void LogMessage(string message, string logType)
        {
            switch(logType.ToUpper())
            {
                case "ERROR":
                    LoggerContext logError = new LoggerContext(new LoggerError());
                    logError.LogMessage(message);
                    break;
                case "INFO":
                    LoggerContext logInfo = new LoggerContext(new LoggerInfo());
                    logInfo.LogMessage(message);
                    break;
                case "WARNING":
                    LoggerContext logWarning = new LoggerContext(new LoggerWarning());
                    logWarning.LogMessage(message);
                    break;
                default:
                    throw new NotImplementedException("Logging type not implemented");

            }
        }
    }
}
