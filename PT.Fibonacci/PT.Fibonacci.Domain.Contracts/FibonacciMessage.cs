using PT.Fibonacci.Infrastructure.Base.Messaging;

namespace PT.Fibonacci.Domain.Contracts
{
    public class FibonacciMessage : IMessage
    {
        public string CorrelationId { get; set; }
        public int Value { get; set; }

        public FibonacciMessage()
        {
        }

        public FibonacciMessage(int value, string correlationId)
        {
            Value = value;
            CorrelationId = correlationId;
        }
    }
}
