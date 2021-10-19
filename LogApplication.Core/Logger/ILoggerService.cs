namespace LogApplication.Core.Logger
{
    public interface ILoggerService
    {
        void LogMessage(string message, string logType);
    }
}
