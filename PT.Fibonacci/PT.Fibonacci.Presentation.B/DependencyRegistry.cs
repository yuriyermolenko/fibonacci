using PT.Fibonacci.Application.Base.Services;
using PT.Fibonacci.Application.Services;
using PT.Fibonacci.Infrastructure.Base.Messaging;
using PT.Fibonacci.Infrastructure.Messaging.MassTransit;
using PT.Fibonacci.Infrastructure.Messaging.Rest;
using StructureMap;

namespace PT.Fibonacci.Presentation.B
{
    public class DependencyRegistry : Registry
    {
        public DependencyRegistry()
        {
            For<IFibonacciService>().Use<FibonacciIterativeService>();
            For<IMessageSender>().Use<MassTransitMessageSender>();

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
