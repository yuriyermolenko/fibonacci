using CommandLine;
using PT.Fibonacci.Presentation.A.CommandLine;

namespace PT.Fibonacci.Presentation.A
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandLineOptions = new Options();

            if (Parser.Default.ParseArguments(args, commandLineOptions))
            {

            }
        }
    }
}
