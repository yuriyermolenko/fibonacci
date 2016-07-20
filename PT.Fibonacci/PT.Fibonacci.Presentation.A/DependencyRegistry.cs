using PT.Fibonacci.Application.Base.Services;
using PT.Fibonacci.Application.Services;
using PT.Fibonacci.Infrastructure.Base.Messaging;
using PT.Fibonacci.Infrastructure.Messaging.MassTransit;
using PT.Fibonacci.Infrastructure.Messaging.Rest;
using StructureMap;

namespace PT.Fibonacci.Presentation.A
{
    public class DependencyRegistry : Registry
    {
        public DependencyRegistry()
        {
            For<IFibonacciService>().Use<FibonacciIterativeService>();
            For<IMessageSender>().Use<RestMessageSender>();
            For<IMessageReceiver>().Use<MassTransitMessageReceiver>();

            For<RestConfiguration>().Use<RestConfiguration>(
                new RestConfiguration
                {
                    TargetUrl = "http://localhost:8080/",
                    TargetRoute = "api/fibonacci"
                });

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
