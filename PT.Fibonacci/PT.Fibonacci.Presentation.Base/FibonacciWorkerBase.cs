using PT.Fibonacci.Application.Base.Services;
using PT.Fibonacci.Domain.Contracts;
using PT.Fibonacci.Infrastructure.Base.Messaging;
using System;
using System.Threading.Tasks;

namespace PT.Fibonacci.Presentation.Base
{
    abstract public class FibonacciWorkerBase
    {
        protected readonly IFibonacciService FibonacciService;
        protected readonly IMessageSender<FibonacciMessage> MessageSender;
        protected string SourceId;

        protected FibonacciWorkerBase(
            IFibonacciService fibonacciService,
            IMessageSender<FibonacciMessage> messageSender)
        {
            SourceId = Guid.NewGuid().ToString();

            this.FibonacciService = fibonacciService;
            this.MessageSender = messageSender;
        }

        protected virtual void DoWork(FibonacciRequest request)
        {
            var result = FibonacciService.CalculateFibonacci(request);

            var message = new FibonacciMessage(result.Value, request.CorrelationId);

            MessageSender.Send(message);
        }
    }
}
