namespace PT.Fibonacci.Application.Base.Services
{
    public class FibonacciResponse
    {
        public int Value { get; private set; }

        public FibonacciResponse(int value)
        {
            this.Value = value;
        }
    }
}
