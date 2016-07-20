using PT.Fibonacci.Domain.Contracts;
using PT.Fibonacci.Infrastructure.Base.Logging;
using System.Net.Http;
using System.Web.Http;
using PT.Fibonacci.Presentation.B.Processing;

namespace PT.Fibonacci.Presentation.B.Controllers
{
    public class FibonacciController : ApiController
    {
        private static readonly ILogger Logger = LoggerFactory.CreateLog();

        private readonly FibonacciWorker _worker;

        public FibonacciController(FibonacciWorker worker)
        {
            _worker = worker;
        }

        [HttpPost]
        public HttpResponseMessage Post(FibonacciMessage message)
        {
            Logger.LogInfo($"Received:{message.CorrelationId}:{message.Number}");
            Logger.LogInfo($"Starting worker for:{message.CorrelationId}:{message.Number}");

            _worker.Perform(message);

            return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
        }
    }
}
