using CommandLine;
using CommandLine.Text;

namespace PT.Fibonacci.Presentation.A.CommandLine
{
    public class Options
    {
        [Option('t', "threads", Required = false, HelpText = "The number of simultaneous threads.", DefaultValue = 1)]
        public int Threads { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this, current => HelpText.DefaultParsingErrorsHandler(this, current));
        }
    }
}
