namespace PT.Fibonacci.Infrastructure.Base.Messaging
{
    public interface IMessage
    {
        string CorrelationId { get; set; }
    }
}
