using PT.Fibonacci.Application.Base.Services;
using PT.Fibonacci.Infrastructure.Base.Logging;
using System.Threading;

namespace PT.Fibonacci.Application.Services
{
    public class FibonacciIterativeService : IFibonacciService
    {
        private static readonly ILogger Logger = LoggerFactory.CreateLog();

        public FibonacciResponse CalculateFibonacci(FibonacciRequest request)
        {
            Logger.LogInfo($"Starting calculation for {request.Value}");

            Thread.Sleep(500);

            return new FibonacciResponse(request.Value + 1);
        }
    }
}
