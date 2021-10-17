using Coworking.DataAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coworking.Api
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
            services.AddDbContext<CoworkingDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DataBaseConnection")));
            services.AddControllers();
            // Configuracion de los servicios Swagger
            var filePath = ConfigurationPath.Combine("Coworking.Api.xml");
            services.AddSwaggerGen(config => config.SwaggerDoc("ArquitecturaV1", new Microsoft.OpenApi.Models.OpenApiInfo
            {
                Title = "Arquitectura N Capas",
                Version = "V1",
                Contact = new Microsoft.OpenApi.Models.OpenApiContact { Name = "Jose Carlos", Email = "jcarlos.duenas@gmail.com" }
            }));
            //incluimos la documentación.
            services.AddSwaggerGen(config => config.IncludeXmlComments(filePath));
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // Configuración de Swagger
            app.UseSwagger();
            app.UseSwaggerUI(config => config.SwaggerEndpoint("/swagger/ArquitecturaV1/swagger.json", "Api de ejemplo swagger"));
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
