using PT.Fibonacci.Infrastructure.Base.Logging;

namespace PT.Fibonacci.Infrastructure.Logging
{
    public class NLogLogFactory : ILoggerFactory
    {
        public ILogger Create()
        {
            return new NLogLogger();
        } 
    }
}