using Owin;
using PT.Fibonacci.Infrastructure.Base.Logging;
using PT.Fibonacci.Infrastructure.Logging;
using System.Web.Http;
using WebApi.StructureMap;

namespace PT.Fibonacci.Presentation.B
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Configure Web API for self-host. 
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );


            config.UseStructureMap(x =>
            {
                x.AddRegistry<DependencyRegistry>();
            });

            RegisterFactories();

            app.UseWebApi(config);
        }

        private static void RegisterFactories()
        {
            LoggerFactory.SetCurrent(new NLogLogFactory());
        }
    }
}
