using PT.Fibonacci.Application.Base.Services;
using PT.Fibonacci.Domain.Contracts;
using PT.Fibonacci.Infrastructure.Base.Messaging;
using PT.Fibonacci.Presentation.Base;

namespace PT.Fibonacci.Presentation.B.Processing
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
            DoWork(new FibonacciRequest(message.Value, message.CorrelationId));
        }
    }
}
