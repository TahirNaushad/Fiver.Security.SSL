using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.AspNetCore.Http;

namespace Fiver.Security.SSL
{
    public class Startup
    {
        public void ConfigureServices(
            IServiceCollection services)
        {
            services.AddMvc(options =>
            {
                options.Filters.Add(new RequireHttpsAttribute());
            });
        }

        public void Configure(
            IApplicationBuilder app, 
            IHostingEnvironment env)
        {
            var options = new RewriteOptions()
                .AddRedirectToHttps(StatusCodes.Status301MovedPermanently, 44384);

            app.UseRewriter(options);

            app.UseMvcWithDefaultRoute();
        }
    }
}
