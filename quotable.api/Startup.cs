using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace quotable.api
{
	/// <summary>
	/// The Startup class that is responsible for configuring the Quotable APIs.
	/// </summary>
    public class Startup
    {
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="configuration">The configuration to use</param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private IConfiguration Configuration { get; }

		/// <summary>
		/// This method adds services to the service container.
		/// </summary>
		/// <param name="services">The service collection to which to add services.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

		/// <summary>
		/// This method is used to configure the HTTP request pipeline.
		/// </summary>
		/// <param name="app">The application builder to use.</param>
		/// <param name="env">Information about the hosting environment.</param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
