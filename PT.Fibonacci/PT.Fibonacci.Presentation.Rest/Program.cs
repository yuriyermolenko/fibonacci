using System;
using System.Configuration;
using Microsoft.Owin.Hosting;
using PT.Fibonacci.Presentation.Base.Configuration;

namespace PT.Fibonacci.Presentation.Rest
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
