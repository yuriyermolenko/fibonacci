namespace PT.Fibonacci.Infrastructure.Base.Messaging
{
    public interface IMessageSender<in T> where T : IMessage
    {
        void Send(T message);
    }
}
