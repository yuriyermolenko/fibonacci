using System.Web.Http;

namespace PT.Fibonacci.Presentation.B.Controllers
{
    public class FibonacciController : ApiController
    {
        [HttpGet]
        public int Get(int value)
        {
            return value + 1;
        }
    }
}
