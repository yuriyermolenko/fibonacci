using PT.Fibonacci.Domain.Contracts;
using System.Net.Http;
using System.Web.Http;

namespace PT.Fibonacci.Presentation.B.Controllers
{
    public class FibonacciController : ApiController
    {
        private readonly FibonacciWorker _worker;

        public FibonacciController(FibonacciWorker worker)
        {
            _worker = worker;
        }

        [HttpGet]
        public HttpResponseMessage Get([FromUri]FibonacciMessage message)
        {
            _worker.Perform(message);

            return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
        }
    }
}
