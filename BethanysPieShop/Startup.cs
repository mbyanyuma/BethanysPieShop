using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace BethanysPieShop
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // This is the dependency injection container for asp.net core (can apply dependency injection here) 
        public void ConfigureServices(IServiceCollection services)
        {
            //dependency injection:
            services.AddTransient<IPieRepository, MockPieRepository>(); /*whenever someone asks for an instance of IPieRepository,
                                                                            A NEW MockPieRepository instance is returned */

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
