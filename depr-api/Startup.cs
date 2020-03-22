using System;
using System.Buffers;
using System.Data.Common;
using System.Diagnostics;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using vdivsvirus.Models;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using vdivsvirus.Interfaces;
using vdivsvirus.Services;

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
            //--------------------
            // Knowledge Service 
            // (Central Knowledge Service)
            IKnowledgeService knowledgeService = new KnowledgeService();

            //--------------------
            // DataSetService 
            // (Central Persistance Service)
            DataSetService dataService = new DataSetService(knowledgeService);
            IRequestDataSet requestService = dataService as IRequestDataSet;
            ISendSymptome sendService = dataService as ISendSymptome;

            //--------------------
            // Data Response Service
            // provide feedback to users
            IResponseService responseService = new ResponseService(requestService, knowledgeService);

            //--------------------
            // Analysing Data
            // PDA - Propabilistic Data Analysis
            // PGA - Propabilistic Gradient Analysis (not implemented)
            var pdaService = new pdaService(requestService, knowledgeService);
            //var pgaService = new pgaService(requestService);

            //--------------------
            // Register Services at IC-Container
            services.AddSingleton<IRequestDataSet>(dataService);
            services.AddSingleton<ISendSymptome>(dataService);
            services.AddSingleton<IKnowledgeService>(knowledgeService);
            services.AddHostedService<pdaService>();
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
