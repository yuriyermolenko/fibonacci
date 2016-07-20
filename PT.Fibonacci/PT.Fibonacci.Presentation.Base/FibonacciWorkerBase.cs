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
        protected readonly IMessageSender MessageSender;
        protected string SourceId;

        protected FibonacciWorkerBase(
            IFibonacciService fibonacciService,
            IMessageSender messageSender)
        {
            SourceId = Guid.NewGuid().ToString();

            this.FibonacciService = fibonacciService;
            this.MessageSender = messageSender;
        }

        public virtual void Start()
        {
            DoWork(new FibonacciRequest(0));
        }

        protected virtual void DoWork(FibonacciRequest request)
        {
            var result = FibonacciService.CalculateFibonacci(request);

            var message = new FibonacciMessage(result.Value, SourceId);

            MessageSender.Send(message);
        }
    }
}
