namespace LogApplication.Core.Logger
{
    public interface ILoggerService
    {
        bool LogMessage(string message, string logType);
    }
}
