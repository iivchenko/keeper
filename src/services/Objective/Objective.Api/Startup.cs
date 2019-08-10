using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Objective.Core.Application.Commands.Common;
using Objective.Core.Application.Commands.Objectives.AddObjective;
using Swashbuckle.AspNetCore.Swagger;

namespace Objective.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddScoped<ICommandHandler<AddObjectiveCommand>, AddObjectiveCommandHandler>();

            services
                .AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services
               .AddSwaggerGen(c =>
               {
                   c.SwaggerDoc("v1", new Info
                   {
                       Version = "v1",
                       Title = "Objectives Api",
                       Contact = new Contact
                       {
                           Name = "Objectives Microservice",
                           Email = "iivchenko@live.com",
                       }
                   });
               });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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

            app.UseMvc();

            app.UseSwagger();
            app
                .UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Objectives Api V1");
                });
        }
    }
}
