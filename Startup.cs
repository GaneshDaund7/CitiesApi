using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First.Api.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.DependencyInjection;

namespace First.Api
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().AddMvcOptions(mvc =>
            {
                mvc.OutputFormatters.Add(new XmlDataContractSerializerOutputFormatter());
                services.AddTransient<LocalMailService>();
             }) ;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }




             app.UseMvc();

           

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("hello from run middleware ");
                // throw new exception("some error occured!");
            });


        }
    }
}
