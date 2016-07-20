﻿using System;
using PT.Fibonacci.Infrastructure.Base.Messaging;

namespace PT.Fibonacci.Infrastructure.Messaging.Rest
{
    public class RestMessageReceiver : IMessageReceiver
    {
        public event EventHandler<MessageReceivedEventArgs> Received;

        private readonly RestConfiguration _config;

        public RestMessageReceiver(RestConfiguration config)
        {
            _config = config;
        }

        public void Start()
        {
            // TODO
        }

        public void Stop()
        {
            // TODO
        }

        protected virtual void OnReceived(IMessage message)
        {
            this.Received?.Invoke(this, new MessageReceivedEventArgs(message));
        }
    }
}
