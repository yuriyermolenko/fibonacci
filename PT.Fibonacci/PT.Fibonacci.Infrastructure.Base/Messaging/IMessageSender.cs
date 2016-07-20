namespace PT.Fibonacci.Infrastructure.Base.Messaging
{
    public interface IMessageSender<T> where T : IMessage
    {
        void Send(T message);
    }
}
