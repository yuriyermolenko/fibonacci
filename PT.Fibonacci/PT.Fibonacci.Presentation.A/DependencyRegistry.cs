using PT.Fibonacci.Application.Base.Services;
using PT.Fibonacci.Application.Services;
using PT.Fibonacci.Domain.Contracts;
using PT.Fibonacci.Infrastructure.Base.Messaging;
using PT.Fibonacci.Infrastructure.Messaging.MassTransit;
using PT.Fibonacci.Infrastructure.Messaging.Rest;
using PT.Fibonacci.Presentation.Base.Configuration;
using StructureMap;
using System.Configuration;

namespace PT.Fibonacci.Presentation.A
{
    public class DependencyRegistry : Registry
    {
        public DependencyRegistry()
        {
            For<IFibonacciService>().Use<FibonacciIterativeService>();
            For<IMessageSender<FibonacciMessage>>().Use<RestMessageSender<FibonacciMessage>>();
            For<IMessageReceiver>().Use<MassTransitMessageReceiver<FibonacciMessage>>();

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var restSettings = (RestConfigurationSettings)config.Sections["rest"];
            var messageBusSettings = (MassTransitConfigurationSettings)config.Sections["messagebus"];

            For<RestConfiguration>().Use<RestConfiguration>(
                new RestConfiguration
                {
                    Url = restSettings.Url,
                    Route = restSettings.Route
                });

            For<MassTransitConfiguration>().Use<MassTransitConfiguration>(
               new MassTransitConfiguration
               {
                   Host = messageBusSettings.Host,
                   Username = messageBusSettings.Username,
                   Password = messageBusSettings.Password
               });
        }
    }
}
