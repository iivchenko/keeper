﻿using AutoMapper;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Objective.Api.Common;
using Objective.Core.Application.Queries.Sql.Common;
using Objective.Core.Domain.Common;
using Objective.Core.Domain.Objectives;
using Objective.Infrastructure.Persistence;
using Objective.Infrastructure.Persistence.Objectives;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.Reflection;

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
            // Common
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddSingleton<IConnectionFactory>(new ConnectionFactory(Configuration["ConnectionString"]));

            // Objectives
            services.AddScoped<IObjectiveFactory, ObjectiveFactory>();
            services.AddScoped<IObjectiveRepository, ObjectiveRepository>();

            services
               .AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services
                .AddMediatR(
                    Assembly.Load("Objective.Core.Application.Commands"),
                    Assembly.Load("Objective.Core.Application.Queries.Sql"));

            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            services
               .AddDbContext<ObjectiveContext>(
                   options =>
                   {
                       options.UseSqlServer(Configuration["ConnectionString"]);
                   });

            services
                .AddMvc()
                .AddFluentValidation(x => x.RegisterValidatorsFromAssemblies(new[] { Assembly.Load("Objective.Core.Application.Commands"), Assembly.Load("Objective.Core.Application.Queries") }))
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

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
