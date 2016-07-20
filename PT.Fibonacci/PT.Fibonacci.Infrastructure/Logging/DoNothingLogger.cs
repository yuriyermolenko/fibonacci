using System;
using PT.Fibonacci.Infrastructure.Base.Logging;

namespace PT.Fibonacci.Infrastructure.Logging
{
    public class DoNothingLogger : ILogger
    {
        public void LogInfo(string message, params object[] args)
        {
            // do nothing
        }

        public void LogWarning(string message, params object[] args)
        {
            // do nothing
        }

        public void LogError(string message, params object[] args)
        {
            // do nothing
        }

        public void LogError(string message, Exception exception, params object[] args)
        {
            // do nothing
        }

        public void Debug(string message, params object[] args)
        {
            // do nothing
        }
    }
}
