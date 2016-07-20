using System;
using PT.Fibonacci.Infrastructure.Base.Messaging;

namespace PT.Fibonacci.Infrastructure.Messaging.MassTransit
{
    public class MassTransitMessageSender : IMessageSender
    {
        private readonly MassTransitConfiguration _config;

        public MassTransitMessageSender(MassTransitConfiguration config)
        {
            _config = config;
        }

        public void Send(IMessage message)
        {
            throw new NotImplementedException();
        }
    }
}
