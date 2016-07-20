namespace PT.Fibonacci.Infrastructure.Base.Logging
{
    public class LoggerFactory
    {
        private static ILoggerFactory _currentLogFactory;

        public static void SetCurrent(ILoggerFactory logFactory)
        {
            _currentLogFactory = logFactory;
        }

        public static ILogger CreateLog()
        {
            return (_currentLogFactory != null) ? _currentLogFactory.Create() : null;
        }
    }
}
