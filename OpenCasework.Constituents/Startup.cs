using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using OpenCaseWork.Core.Hosting;
using OpenCaseWork.Constituents.Data;
using Microsoft.EntityFrameworkCore;
using OpenCaseWork.Core.Data;
using OpenCaseWork.Models.Constituents;
using Newtonsoft.Json.Serialization;

namespace OpenCaseWork.Constituents
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.             
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder =>
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });
            services.AddMvc()
              .AddJsonOptions(opts =>
              {
                  opts.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
              });

            services.AddDbContext<ConstituentContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));


            // Add application services.
            services.AddSingleton<IDomainRepository, DomainRepository>();
            services.AddSingleton<IContactEventDomainRepository, ContactEventDomainRepository>();
            services.AddSingleton<IConstituentRepository, ConstituentRepository>();
            services.AddSingleton<IEntityRepository, EntityRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            CoreStartup.ConfigureLogging(env, loggerFactory, Configuration);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseCors("CorsPolicy");
            }
     
            app.UseMvc();
            
        }
    }
}
