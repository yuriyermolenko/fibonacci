using PT.Fibonacci.Application.Base.Services;
using PT.Fibonacci.Infrastructure.Base.Messaging;
using PT.Fibonacci.Presentation.Base;

namespace PT.Fibonacci.Presentation.A
{
    public class FibonacciWorker : FibonacciWorkerBase
    {
        public FibonacciWorker(
            IFibonacciService fibonacciService, 
            IMessageSender messageSender, 
            IMessageReceiver messageReceiver) :
            base(fibonacciService, messageSender, messageReceiver)
        {
        }
    }
}
