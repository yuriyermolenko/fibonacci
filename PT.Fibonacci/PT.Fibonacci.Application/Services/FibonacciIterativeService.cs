using PT.Fibonacci.Application.Base.Services;
using PT.Fibonacci.Infrastructure.Base.Logging;
using System.Threading;
using PT.Fibonacci.Domain;

namespace PT.Fibonacci.Application.Services
{
    public class FibonacciIterativeService : IFibonacciService
    {
        private static readonly ILogger Logger = LoggerFactory.CreateLog();

        public FibonacciResponse CalculateFibonacci(FibonacciRequest request)
        {
            Logger.LogInfo($"Starting calculation for {request.Number}");

            Thread.Sleep(500);

            return new FibonacciResponse(new FibonacciNumber(request.Number.Value + 1, request.Number.Index + 1));
        }
    }
}
