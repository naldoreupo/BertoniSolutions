using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AutoMapper;
using Bertoni.Domain;
using Bertoni.Domain.Entity;
using Bertoni.Infraestructure.Entity;
using Bertoni.Infraestructure.Interface;
using Bertoni.Infraestructure.Repository;
using Bertoni.Service.Entity;
using Bertoni.Transversal;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Bertoni.Service
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
            services.AddControllers();
            services.AddCors();


            IMapper iMapper = Maps.InitMapper();
            services.AddSingleton(iMapper);

            services.AddScoped<InterfaceAlbumDomain, AlbumDomain>();
            services.AddScoped<InterfaceAlbumRepository<AlbumOutputModel>, AlbumRepository>();
            services.AddScoped<InterfacePhotoDomain, PhotoDomain>();
            services.AddScoped<InterfacePhotoRepository<PhotoOutputModel>, PhotoRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseCors(builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyHeader()
                       .AllowAnyMethod();
            });
        }
    }
}
