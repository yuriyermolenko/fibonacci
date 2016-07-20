using System;

namespace PT.Fibonacci.Infrastructure.Base.Messaging
{
    public interface IMessageReceiver
    {
        void Start();
        void Stop();

        event EventHandler<MessageReceivedEventArgs> Received;
    }
}
