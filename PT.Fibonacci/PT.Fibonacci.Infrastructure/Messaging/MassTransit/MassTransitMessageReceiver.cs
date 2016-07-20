using System;
using PT.Fibonacci.Infrastructure.Base.Messaging;

namespace PT.Fibonacci.Infrastructure.Messaging.MassTransit
{
    public class MassTransitMessageReceiver : IMessageReceiver
    {
        public event EventHandler<MessageReceivedEventArgs> Received;

        private readonly MassTransitConfiguration _config;

        public MassTransitMessageReceiver(MassTransitConfiguration config)
        {
            _config = config;
        }

        public void Start()
        {
            // TODO
            //throw new NotImplementedException();
        }

        public void Stop()
        {
            // TODO
            //throw new NotImplementedException();
        }

        protected virtual void OnReceived(IMessage message)
        {
            this.Received?.Invoke(this, new MessageReceivedEventArgs(message));
        }
    }
}
