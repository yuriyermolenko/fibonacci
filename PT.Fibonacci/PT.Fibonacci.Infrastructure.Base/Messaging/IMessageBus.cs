namespace PT.Fibonacci.Infrastructure.Base.Messaging
{
    public interface IMessageBus
    {
        void Publish(IMessage message);
    }
}
