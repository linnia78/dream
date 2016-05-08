using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Dream.Core
{
    public class ConfigurationFactory
    {
        private IConfigurationRoot Configuration { get; set; }

        public ConfigurationFactory()
        {
        }

        public IConfigurationRoot GetConfiguration()
        {
            this.Configuration = Configuration ?? new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true)
                .AddUserSecrets()
                .AddEnvironmentVariables()
                .Build();
            return this.Configuration;
        }
    }
}
