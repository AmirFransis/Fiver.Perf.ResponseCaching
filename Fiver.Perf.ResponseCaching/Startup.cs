using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;

namespace Fiver.Asp.ResponseCaching
{
    public class Startup
    {
        public void ConfigureServices(
            IServiceCollection services)
        {
            services.AddResponseCaching();

            services.AddMvc(options =>
            {
                options.CacheProfiles.Add("default", new CacheProfile
                {
                    Duration = 30,
                    Location = ResponseCacheLocation.Any
                });
            });
        }

        public void Configure(
            IApplicationBuilder app, 
            IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();

            app.UseResponseCaching();

            app.UseMvcWithDefaultRoute();
        }
    }
}
