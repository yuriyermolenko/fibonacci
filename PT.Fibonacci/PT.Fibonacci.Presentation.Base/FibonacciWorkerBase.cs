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
        protected readonly IMessageReceiver MessageReceiver;

        private string _sourceId;

        protected FibonacciWorkerBase(
            IFibonacciService fibonacciService,
            IMessageSender messageSender,
            IMessageReceiver messageReceiver)
        {
            _sourceId = Guid.NewGuid().ToString();

            this.FibonacciService = fibonacciService;
            this.MessageSender = messageSender;
            this.MessageReceiver = messageReceiver;

            this.MessageReceiver.Received += OnMessageReceived;
        }

        public void StartAsync()
        {
            Task.Run(() => Start());
        }

        public void Start()
        {
            DoWork(new FibonacciRequest(0));
        }

        protected virtual void DoWork(FibonacciRequest request)
        {
            var result = FibonacciService.CalculateFibonacci(request);

            var message = new FibonacciMessage(result.Value, _sourceId);

            MessageSender.Send(message);
        }

        private void OnMessageReceived(object sender, MessageReceivedEventArgs e)
        {
            if (e.Message.CorrelationId == _sourceId)
            {
                var fibonacciMessage = e.Message as FibonacciMessage;

                if (fibonacciMessage != null) {

                    DoWork(new FibonacciRequest(fibonacciMessage.Value));
                }
            }
        }
    }
}
