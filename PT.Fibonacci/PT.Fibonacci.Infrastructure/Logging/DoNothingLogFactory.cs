using PT.Fibonacci.Infrastructure.Base.Logging;

namespace PT.Fibonacci.Infrastructure.Logging
{
    public class DoNothingLogFactory : ILoggerFactory
    {
        public ILogger Create()
        {
            return new DoNothingLogger();
        }
    }
}
