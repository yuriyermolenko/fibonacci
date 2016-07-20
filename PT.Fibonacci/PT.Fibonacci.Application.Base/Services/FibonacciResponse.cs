using PT.Fibonacci.Domain;

namespace PT.Fibonacci.Application.Base.Services
{
    public class FibonacciResponse
    {
        public FibonacciNumber Number { get; private set; }

        public FibonacciResponse(FibonacciNumber number)
        {
            Number = number;
        }
    }
}
