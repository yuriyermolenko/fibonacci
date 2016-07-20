using System;
using PT.Fibonacci.Infrastructure.Base.Messaging;

namespace PT.Fibonacci.Domain.Contracts
{
    public class FibonacciMessage : IMessage
    {
        public string CorrelationId { get; private set; }
        public int Value { get; private set; }

        public FibonacciMessage(int value, string correlationId)
        {
            this.Value = value;
            this.CorrelationId = correlationId;
        }
    }
}
