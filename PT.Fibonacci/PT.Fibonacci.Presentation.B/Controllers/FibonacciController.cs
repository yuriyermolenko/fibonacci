using PT.Fibonacci.Domain.Contracts;
using PT.Fibonacci.Infrastructure.Base.Logging;
using System.Net.Http;
using System.Web.Http;

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
            Logger.LogInfo($"Received:{message.CorrelationId}:{message.Value}");
            Logger.LogInfo($"Starting worker for:{message.CorrelationId}:{message.Value}");

            _worker.Perform(message);

            return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
        }
    }
}
