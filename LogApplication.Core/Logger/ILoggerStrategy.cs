namespace LogApplication.Core.Logger
{
    public interface ILoggerStrategy
    {
        void LogMessage(string message);
    }
}
