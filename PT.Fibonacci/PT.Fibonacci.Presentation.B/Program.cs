using Microsoft.Owin.Hosting;
using PT.Fibonacci.Presentation.Base.Configuration;
using System;
using System.Configuration;

namespace PT.Fibonacci.Presentation.B
{
    class Program
    {
        static void Main()
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var restSettings = (RestConfigurationSettings)config.Sections["rest"];

            using (WebApp.Start<Startup>(restSettings.Url))
            {
                Console.WriteLine("Web Server is running.");
                Console.WriteLine("Press any key to quit.");
                Console.ReadLine();
            }
        }
    }
}
