using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

using vdivsvirus.Interfaces;
using vdivsvirus.Services;

namespace vdivsvirus
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {


            //----------------
            // DataSetService 
            // (Central Service)
            DataSetService dataService = new DataSetService();
            IRequestDataSet requestService = dataService as IRequestDataSet;
            ISendSymptome sendService = dataService as ISendSymptome;

            IResponseService responseService = new ResponseService(requestService);

            var pdaService = new pdaService(requestService);
            var pgaService = new pgaService(requestService);

            services.AddSingleton<IRequestDataSet>(dataService);
            services.AddSingleton<ISendSymptome>(dataService);
            // services.AddHostedService<pdaService>();
            // services.AddHostedService<pgaService>();


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
