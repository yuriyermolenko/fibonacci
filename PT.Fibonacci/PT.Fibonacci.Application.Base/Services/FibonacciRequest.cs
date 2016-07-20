namespace PT.Fibonacci.Application.Base.Services
{
    public class FibonacciRequest
    {
        public int Value { get; private set; }
        public string CorrelationId { get; private set; }

        public FibonacciRequest(int value, string correlationId)
        {
            Value = value;
            CorrelationId = correlationId;
        }
    }
}
