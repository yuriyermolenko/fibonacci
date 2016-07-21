using System;
using PT.Fibonacci.Infrastructure.Base.Messaging;
using RestSharp;

namespace PT.Fibonacci.Infrastructure.Messaging.Rest
{
    public class RestMessageSender<T> : IMessageSender<T> where T : class, IMessage
    {
        private readonly RestConfiguration _config;

        public RestMessageSender(RestConfiguration config)
        {
            _config = config;
        }
        
        public void Send(T message)
        {
            var client = new RestClient(_config.Url);

            var request = new RestRequest(_config.Route, Method.POST);
            request.AddObject(message);

            var response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new Exception("The destination host is not available"); // TODO add custom application exceptions and handling
            }
        }
    }
}
