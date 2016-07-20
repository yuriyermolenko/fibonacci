using System.Data.SqlTypes;
using PT.Fibonacci.Infrastructure.Base.Messaging;

namespace PT.Fibonacci.Domain.Contracts
{
    public class FibonacciMessage : IMessage
    {
        public string CorrelationId { get; set; }

        public int Index { get; set; }
        public int Value { get; set; }

        public FibonacciNumber Number => new FibonacciNumber(Value, Index);

        public FibonacciMessage()
        {
        }

        public FibonacciMessage(FibonacciNumber number, string correlationId)
        {
            Index = number.Index;
            Value = number.Value;
            CorrelationId = correlationId;
        }
    }
}
