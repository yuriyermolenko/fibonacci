namespace PT.Fibonacci.Application.Base.Services
{
    public interface IFibonacciService
    {
        FibonacciResponse CalculateFibonacci(FibonacciRequest request);
    }
}
