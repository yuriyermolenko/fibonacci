namespace PT.Fibonacci.Application.Base.Services
{
    public class FibonacciRequest
    {
        public int Value { get; private set; }

        public FibonacciRequest(int value)
        {
            this.Value = value;
        }
    }
}
