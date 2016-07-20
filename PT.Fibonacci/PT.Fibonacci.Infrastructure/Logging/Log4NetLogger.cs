using System;
using PT.Fibonacci.Infrastructure.Base.Logging;
using log4net;

namespace PT.Fibonacci.Infrastructure.Logging
{
    public class Log4NetLogger : ILogger
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Log4NetLogger));

        public void Debug(string message, params object[] args)
        {
            log.DebugFormat(message, args);
        }

        public void LogError(string message, params object[] args)
        {
            log.ErrorFormat(message, args);
        }

        public void LogInfo(string message, params object[] args)
        {
            log.InfoFormat(message, args);
        }

        public void LogWarning(string message, params object[] args)
        {
            log.WarnFormat(message, args);
        }
    }
}
