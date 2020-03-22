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
    /// build together within a monolitic application
    /// structure. 
    /// 
    /// In a scalable application environment, the services
    /// can be seperated into several standalone service
    /// who are working via rest interfaces as micro-service
    /// system.
    /// </summary>
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;

            }

            await host.RunAsync();
        }





        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
            
            
    }
}
