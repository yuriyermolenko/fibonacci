namespace PT.Fibonacci.Infrastructure.Logging
{
    public interface ILoggerFactory
    {
        ILogger Create();
    }
}
