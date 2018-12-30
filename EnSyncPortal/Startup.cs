using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnSyncPortal.Controllers.Validators.Implementations;
using EnSyncPortal.Controllers.Validators.Interfaces;
using EnSyncPortal.Models;
using EnSyncPortal.Models.Context;
using EnSyncPortal.Repository.Implementation;
using EnSyncPortal.Repository.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Serialization;

namespace EnSyncPortal
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
            services.AddDbContext<EmployeeContext>(opts => opts.UseSqlServer(Configuration["ConnectionString:EnSyncPortalDev"]));
            services.AddDbContext<EmployeeProfileContext>(opts => opts.UseSqlServer(Configuration["ConnectionString:EnSyncPortalDev"]));
            services.AddDbContext<EmployeeContactContext>(opts => opts.UseSqlServer(Configuration["ConnectionString:EnSyncPortalDev"]));
            services.AddDbContext<DepartmentContext>(opts => opts.UseSqlServer(Configuration["ConnectionString:EnSyncPortalDev"]));
            services.AddDbContext<SkillListContext>(opts => opts.UseSqlServer(Configuration["ConnectionString:EnSyncPortalDev"]));
            services.AddScoped<IEmployeeRepository<Employee>, EmployeeRepository>();
            services.AddScoped<IEmployeeControllerValidator, EmployeeControllerValidator>();
            services.AddLogging();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1).AddJsonOptions(options =>
              options.SerializerSettings.ContractResolver = new DefaultContractResolver());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(minLevel: LogLevel.Information);
            loggerFactory.AddFile("Logs/EnSyncPortal-{Date}.txt");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseMvc();
        }
    }
}
