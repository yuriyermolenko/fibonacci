using PT.Fibonacci.Application.Base.Services;
using PT.Fibonacci.Application.Services;
using PT.Fibonacci.Domain.Contracts;
using PT.Fibonacci.Infrastructure.Base.Messaging;
using PT.Fibonacci.Infrastructure.Messaging.MassTransit;
using StructureMap;

namespace PT.Fibonacci.Presentation.B
{
    public class DependencyRegistry : Registry
    {
        public DependencyRegistry()
        {
            For<IFibonacciService>().Use<FibonacciIterativeService>();
            For<IMessageSender<FibonacciMessage>>().Use<MassTransitMessageSender<FibonacciMessage>>();

            For<MassTransitConfiguration>().Use<MassTransitConfiguration>(
               new MassTransitConfiguration
               {
                   Host = "rabbitmq://localhost/",
                   Username = "echelon",
                   Password = "echeloncorp"
               });
        }
    }
}
