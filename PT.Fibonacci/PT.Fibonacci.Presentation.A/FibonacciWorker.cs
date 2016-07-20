using PT.Fibonacci.Application.Base.Services;
using PT.Fibonacci.Domain.Contracts;
using PT.Fibonacci.Infrastructure.Base.Logging;
using PT.Fibonacci.Infrastructure.Base.Messaging;
using PT.Fibonacci.Presentation.Base;
using System.Threading.Tasks;

namespace PT.Fibonacci.Presentation.A
{
    public class FibonacciWorker : FibonacciWorkerBase
    {
        private static readonly ILogger Logger = LoggerFactory.CreateLog();

        private readonly IMessageReceiver _messageReceiver;

        public FibonacciWorker(
            IFibonacciService fibonacciService,
            IMessageSender<FibonacciMessage> messageSender, 
            IMessageReceiver messageReceiver) :
            base(fibonacciService, messageSender)
        {
            _messageReceiver = messageReceiver;
            _messageReceiver.Received += OnMessageReceived;
        }

        public Task StartAsync()
        {
            return Task.Run(() => Start());
        }

        public void Start()
        {
            Logger.LogInfo("Starting worker");

            _messageReceiver.Start();
            DoWork(new FibonacciRequest(0, SourceId));
        }

        protected virtual void OnMessageReceived(object sender, MessageReceivedEventArgs e)
        {
            Logger.LogInfo($"Received message: {e.Message.CorrelationId}");

            if (e.Message.CorrelationId == SourceId)
            {
                var fibonacciMessage = e.Message as FibonacciMessage;

                if (fibonacciMessage != null)
                {
                    Logger.LogInfo($"Received value: {fibonacciMessage.Value} ");

                    DoWork(new FibonacciRequest(fibonacciMessage.Value, fibonacciMessage.CorrelationId));
                }
            } else
            {
                Logger.LogInfo($"Skipping message: {e.Message.CorrelationId}");
            }
        }
    }
}
