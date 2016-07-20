using System;
using PT.Fibonacci.Infrastructure.Base.Messaging;
using MassTransit;
using System.Threading.Tasks;

namespace PT.Fibonacci.Infrastructure.Messaging.MassTransit
{
    public class MassTransitMessageReceiver : IMessageReceiver, IConsumer<IMessage>
    {
        public event EventHandler<MessageReceivedEventArgs> Received;

        private readonly MassTransitConfiguration _config;
        private readonly IBusControl _host;

        public MassTransitMessageReceiver(MassTransitConfiguration config)
        {
            _config = config;

            _host = Bus.Factory.CreateUsingRabbitMq(cfg =>
            {
                var host = cfg.Host(new Uri(_config.Host), h =>
                {
                    h.Username(_config.Username);
                    h.Password(_config.Password);
                });

                cfg.ReceiveEndpoint(host, e =>
                {
                    e.Instance(this);
                });
            });
        }

        public void Start()
        {
            _host.Start();
        }

        public void Stop()
        {
            _host.Stop();
        }

        protected virtual void OnReceived(IMessage message)
        {
            this.Received?.Invoke(this, new MessageReceivedEventArgs(message));
        }

        public Task Consume(ConsumeContext<IMessage> context)
        {
            OnReceived(context.Message);
            return Task.FromResult(0);
        }
    }
}
