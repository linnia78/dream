using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Dream.Core
{
    public class AppSettings
    {
        public IConfigurationRoot Configuration { get; set; }

        public AppSettings()
        {
            this.Configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true)
                .AddUserSecrets()
                .AddEnvironmentVariables()
                .Build();
        }
    }
}
