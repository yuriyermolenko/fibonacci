using System;
using PT.Fibonacci.Infrastructure.Base.Messaging;
using MassTransit;

namespace PT.Fibonacci.Infrastructure.Messaging.MassTransit
{
    public class MassTransitMessageSender : IMessageSender
    {
        private readonly MassTransitConfiguration _config;
        private readonly IBusControl _host;

        public MassTransitMessageSender(MassTransitConfiguration config)
        {
            _config = config;

            _host = Bus.Factory.CreateUsingRabbitMq(cfg =>
            {
                var host = cfg.Host(new Uri(config.Host), h =>
                {
                    h.Username(config.Username);
                    h.Password(config.Password);
                });
            });
        }

        public void Send(IMessage message)
        {
            _host.Publish(message);
        }
    }
}
