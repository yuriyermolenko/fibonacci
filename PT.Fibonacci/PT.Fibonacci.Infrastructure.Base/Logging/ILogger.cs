using System;

namespace PT.Fibonacci.Infrastructure.Base.Logging
{
    public interface ILogger
    {
        void LogInfo(string message, params object[] args);
        void LogWarning(string message, params object[] args);
        void LogError(string message, params object[] args);
        void Debug(string message, params object[] args);
    }
}
