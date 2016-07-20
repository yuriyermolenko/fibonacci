using PT.Fibonacci.Application.Base.Services;
using PT.Fibonacci.Domain.Contracts;
using PT.Fibonacci.Infrastructure.Base.Logging;
using PT.Fibonacci.Infrastructure.Base.Messaging;
using PT.Fibonacci.Presentation.Base;

namespace PT.Fibonacci.Presentation.A
{
    public class FibonacciWorker : FibonacciWorkerBase
    {
        private static ILogger _logger = LoggerFactory.CreateLog();

        private readonly IMessageReceiver _messageReceiver;

        public FibonacciWorker(
            IFibonacciService fibonacciService, 
            IMessageSender messageSender, 
            IMessageReceiver messageReceiver) :
            base(fibonacciService, messageSender)
        {
            _messageReceiver = messageReceiver;
            _messageReceiver.Received += OnMessageReceived;
        }

        public void Start()
        {
            _logger.LogInfo("Starting worker");

            _messageReceiver.Start();
            DoWork(new FibonacciRequest(0, this.SourceId));
        }

        protected virtual void OnMessageReceived(object sender, MessageReceivedEventArgs e)
        {
            _logger.LogInfo($"Received message: {e.Message.CorrelationId}");

            if (e.Message.CorrelationId == SourceId)
            {
                var fibonacciMessage = e.Message as FibonacciMessage;

                if (fibonacciMessage != null)
                {
                    _logger.LogInfo($"Received message: {fibonacciMessage.Value} ");

                    DoWork(new FibonacciRequest(fibonacciMessage.Value, fibonacciMessage.CorrelationId));
                }
            } else
            {
                _logger.LogInfo($"Skipping it");
            }
        }
    }
}
