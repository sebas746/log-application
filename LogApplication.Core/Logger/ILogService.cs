namespace LogApplication.Core.Logger
{
    public interface ILogService
    {
        void LogMessage(string message, string logType);
    }
}
