using PT.Fibonacci.Application.Base.Services;
using PT.Fibonacci.Application.Services;
using PT.Fibonacci.Domain.Contracts;
using PT.Fibonacci.Infrastructure.Base.Messaging;
using PT.Fibonacci.Infrastructure.Messaging.MassTransit;
using PT.Fibonacci.Presentation.Base.Configuration;
using StructureMap;
using System.Configuration;

namespace PT.Fibonacci.Presentation.B
{
    public class DependencyRegistry : Registry
    {
        public DependencyRegistry()
        {
            For<IFibonacciService>().Use<FibonacciIterativeService>();
            For<IMessageSender<FibonacciMessage>>().Use<MassTransitMessageSender<FibonacciMessage>>();

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var messageBusSettings = (MassTransitConfigurationSettings)config.Sections["messagebus"];

            For<MassTransitConfiguration>().Use(
               new MassTransitConfiguration
               {
                   Host = messageBusSettings.Host,
                   Username = messageBusSettings.Username,
                   Password = messageBusSettings.Password
               });
        }
    }
}
