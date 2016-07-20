using PT.Fibonacci.Domain;

namespace PT.Fibonacci.Application.Base.Services
{
    public class FibonacciRequest
    {
        public FibonacciNumber Number { get; private set; }
        public string CorrelationId { get; private set; }

        public FibonacciRequest(FibonacciNumber number, string correlationId)
        {
            Number = number;
            CorrelationId = correlationId;
        }
    }
}
