using PT.Fibonacci.Presentation.Base;
using PT.Fibonacci.Application.Base.Services;
using PT.Fibonacci.Infrastructure.Base.Messaging;
using PT.Fibonacci.Domain.Contracts;

namespace PT.Fibonacci.Presentation.B
{
    public class FibonacciWorker : FibonacciWorkerBase
    {
        public FibonacciWorker(
            IFibonacciService fibonacciService,
            IMessageSender<FibonacciMessage> messageSender) 
            : base(fibonacciService, messageSender)
        {
        }

        public void Perform(FibonacciMessage message)
        {
            base.DoWork(new FibonacciRequest(message.Value, message.CorrelationId));
        }
    }
}
