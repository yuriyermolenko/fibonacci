using CommandLine;
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

                var worker = container.GetInstance<FibonacciWorker>();

                //worker.StartAsync();
                worker.Start();

                Console.ReadLine();
            }
        }
    }
}
