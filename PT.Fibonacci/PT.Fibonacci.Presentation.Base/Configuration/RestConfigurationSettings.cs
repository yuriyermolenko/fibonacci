using System.Configuration;

namespace PT.Fibonacci.Presentation.Base.Configuration
{
    public class RestConfigurationSettings : ConfigurationSection
    {
        [ConfigurationProperty("url", DefaultValue = "http://localhost:8080/")]
        public string Url
        {
            get { return (string)this["url"]; }
            set { this["url"] = value; }
        }


        [ConfigurationProperty("route", DefaultValue = "api/fibonacci")]
        public string Route
        {
            get { return (string)this["route"]; }
            set { this["route"] = value; }
        }
    }
}
