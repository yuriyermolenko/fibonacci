namespace PT.Fibonacci.Infrastructure.Base.Messaging
{
    public interface IMessageReceiver
    {
        void Start();
        void Stop();
    }
}
