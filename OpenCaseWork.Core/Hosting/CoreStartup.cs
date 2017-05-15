using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OpenCaseWork.Core.Middleware;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Swagger;

namespace OpenCaseWork.Core.Hosting
{
    public class CoreStartup
    {
        public static void AddSwagger(IServiceCollection services, string title, string version)
        {
            services.AddSwaggerGen(c =>
            {
               c.SwaggerDoc(version, new Info { Title = title, Version = version });
            });
        }

        public static void RegisterCoreServices(IServiceCollection services, IConfigurationRoot Configuration)
        {
            // Register the Configuration for http (reads from json config
            //services.Configure<HttpOptions>(Configuration);

            //Add automapper and in memory caching
            //services.AddMemoryCache();

            //add core services
            //services.AddTransient<IApiClient, ApiClient>();
        }

        public static void ConfigureLogging(IHostingEnvironment env, ILoggerFactory loggerFactory, IConfigurationRoot Configuration)
        {

            if (env.IsDevelopment())
            {
                loggerFactory.AddConsole(Configuration.GetSection("Logging"));
                loggerFactory.AddDebug();
                loggerFactory.AddFile("Logs/Server-{Date}.txt", LogLevel.Error, null, false, null, 10);
            }
            else
            {
                loggerFactory.AddFile("Logs/Server-{Date}.txt", LogLevel.Error, null, false, null, 10);
                // TODO: add custom log insight provider
            }
        }

        public static void Configure(IApplicationBuilder app)
        {
            //error handling custom middleware for exceptions
            app.UseMiddleware(typeof(ErrorHandlingMiddleware));

        }

        public static void ConfigureSwagger(IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "V1 Docs");
            });
        }
    }
}
