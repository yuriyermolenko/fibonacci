using System;

namespace PT.Fibonacci.Infrastructure.Base.Messaging
{
    public class MessageReceivedEventArgs : EventArgs
    {
        public IMessage Message { get; private set; }

        public MessageReceivedEventArgs(IMessage message)
        {
            this.Message = message;
        }
    }
}
