using System.Configuration;

namespace PT.Fibonacci.Presentation.Base.Configuration
{
    public class MassTransitConfigurationSettings : ConfigurationSection
    {
        [ConfigurationProperty("host", DefaultValue = "rabbitmq://localhost/")]
        public string Host
        {
            get { return (string)this["host"]; }
            set { this["host"] = value; }
        }

        [ConfigurationProperty("username", DefaultValue = "guest")]
        public string Username
        {
            get { return (string)this["username"]; }
            set { this["username"] = value; }
        }

        [ConfigurationProperty("password", DefaultValue = "guest")]
        public string Password
        {
            get { return (string)this["password"]; }
            set { this["password"] = value; }
        }
    }
}
