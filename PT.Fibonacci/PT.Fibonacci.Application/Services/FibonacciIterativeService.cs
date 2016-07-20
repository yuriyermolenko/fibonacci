using PT.Fibonacci.Application.Base.Services;
using System.Threading;
using System.Threading.Tasks;

namespace PT.Fibonacci.Application.Services
{
    public class FibonacciIterativeService : IFibonacciService
    {
        public FibonacciResponse CalculateFibonacci(FibonacciRequest request)
        {
            Thread.Sleep(500);

            // TODO to implement
            return new FibonacciResponse(request.Value + 1);
        }
    }
}
