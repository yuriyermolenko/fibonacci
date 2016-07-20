using PT.Fibonacci.Infrastructure.Base.Logging;

namespace PT.Fibonacci.Infrastructure.Logging
{
    public class NLogLogFactory : ILoggerFactory
    {
        #region Public methods

        public ILogger Create()
        {
            return new NLogLogger();
        } 

        #endregion
    }
}