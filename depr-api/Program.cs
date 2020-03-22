using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;



namespace vdivsvirus
{

    /// <summary>
    /// Program Bootstrapper of the DPER Application
    /// (Disease Pattern Early Recognition Application)
    /// 
    /// see ArchitectureDocumentation about the different
    /// combined systems.
    /// 
    /// Attention:
    /// For the hackathon the several service parts are 
    /// build together within a monolithic application
    /// structure. 
    /// 
    /// In a scalable application environment, the services
    /// can be separated into several standalone service
    /// who are working via rest interfaces as micro-service
    /// system.
    /// </summary>
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();

            await host.RunAsync();
        }

        /// <summary>
        /// Configure Startup
        /// (Configure rest of Builder here)</summary>
        /// <param name="args">console parameters</param>
        /// <returns></returns>
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
            
            
    }
}
