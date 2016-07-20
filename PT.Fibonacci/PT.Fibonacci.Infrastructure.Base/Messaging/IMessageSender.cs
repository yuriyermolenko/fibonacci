namespace PT.Fibonacci.Infrastructure.Base.Messaging
{
    public interface IMessageSender
    {
        void Send(IMessage message);
    }
}
