using PT.Fibonacci.Application.Base.Services;

namespace PT.Fibonacci.Application.Services
{
    public class FibonacciIterativeService : IFibonacciService
    {
        public FibonacciResponse CalculateFibonacci(FibonacciRequest request)
        {
            // TODO to implement
            return new FibonacciResponse(request.Value + 1);
        }
    }
}
