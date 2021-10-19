using System;

namespace LogApplication.Core.Logger
{
    public class LogService : ILogService
    {
        public LogService()
        {
        }

        public void LogMessage(string message, string logType)
        {
            switch(logType.ToUpper())
            {
                case "ERROR":
                    LoggerContext logError = new LoggerContext(new LoggerError());
                    logError.Validate(message);
                    break;
                case "INFO":
                    LoggerContext logInfo = new LoggerContext(new LoggerInfo());
                    logInfo.Validate(message);
                    break;
                case "WARNING":
                    LoggerContext logWarning = new LoggerContext(new LoggerWarning());
                    logWarning.Validate(message);
                    break;
                default:
                    throw new NotImplementedException("Logging type not implemented");

            }
        }
    }
}
