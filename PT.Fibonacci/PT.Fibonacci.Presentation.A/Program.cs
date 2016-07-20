using CommandLine;
using PT.Fibonacci.Infrastructure.Base.Logging;
using PT.Fibonacci.Infrastructure.Logging;
using PT.Fibonacci.Presentation.A.CommandLine;
using PT.Fibonacci.Presentation.Base;
using StructureMap;
using System;

namespace PT.Fibonacci.Presentation.A
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandLineOptions = new Options();

            if (Parser.Default.ParseArguments(args, commandLineOptions))
            {
                var container = new Container(new DependencyRegistry());
                RegisterFactories();

                var worker = container.GetInstance<FibonacciWorker>();

                //worker.StartAsync();
                worker.Start();

                Console.ReadLine();
            }
        }

        private static void RegisterFactories()
        {
            LoggerFactory.SetCurrent(new NLogLogFactory());
        }
    }
}
