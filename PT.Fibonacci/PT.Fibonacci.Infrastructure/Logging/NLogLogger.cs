using System;
using NLog;
using ILogger = PT.Fibonacci.Infrastructure.Base.Logging.ILogger;

namespace PT.Fibonacci.Infrastructure.Logging
{
    public class NLogLogger : ILogger
    {
        #region Fields and properties

        private readonly Logger _logger = LogManager.GetCurrentClassLogger();

        #endregion

        #region Public methods

        public void LogInfo(string message, params object[] args)
        {
            _logger.Info(message, args);
        }

        public void LogWarning(string message, params object[] args)
        {
            _logger.Warn(message, args);
        }

        public void LogError(string message, params object[] args)
        {
            _logger.Error(message, args);
        }

        public void LogError(string message, Exception exception, params object[] args)
        {
            _logger.Error(exception, message, args);
        }

        public void LogError(string message, Exception exception, string identity, params object[] args)
        {
            var evt = new LogEventInfo(LogLevel.Error, string.Empty, message)
            {
                Exception = exception, 
                Parameters = args
            };
            evt.Properties.Add("Identity", identity);
            _logger.Log(evt);
        }

        public void Debug(string message, params object[] args)
        {
            _logger.Debug(message, args);
        }

        #endregion
    }
}