using System;
using PT.Fibonacci.Infrastructure.Base.Messaging;

namespace PT.Fibonacci.Infrastructure.Messaging.Rest
{
    public class RestMessageSender : IMessageSender
    {
        private readonly RestConfiguration _config;

        public RestMessageSender(RestConfiguration config)
        {
            _config = config;
        }
        
        public void Send(IMessage message)
        {
            throw new NotImplementedException();
        }
    }
}
