using CommandLine;
using PT.Fibonacci.Infrastructure.Base.Logging;
using PT.Fibonacci.Infrastructure.Logging;
using PT.Fibonacci.Presentation.A.CommandLine;
using StructureMap;
using System.Collections.Generic;
using System.Threading.Tasks;
using PT.Fibonacci.Presentation.A.Dependencies;
using PT.Fibonacci.Presentation.A.Processing;

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

                var tasks = new List<Task>(commandLineOptions.Threads);

                for (var i = 0; i < commandLineOptions.Threads; i++)
                {
                    tasks.Add(container.GetInstance<FibonacciWorker>().StartAsync());
                }

                Task.WaitAll(tasks.ToArray());
            }
        }

        private static void RegisterFactories()
        {
            LoggerFactory.SetCurrent(new NLogLogFactory());
        }
    }
}
