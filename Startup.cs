using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using curso_mvc_core.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace curso_mvc_core
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
            services.AddControllersWithViews();
            //Aplicamos compatibilidad para versiones anteriores.
            services.AddMvc().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0);

            //Inyectamos la conexión a la base de datos temporal
            /*services.AddDbContext<EscuelaContext>(
                options => options.UseInMemoryDatabase(databaseName: "dbtemp")
            );*/

            //Inyectamos la conexión a la base de datos SQL Server
            /*string connString = ConfigurationExtensions.GetConnectionString(this.Configuration, "DefaultConnectionSQL");
            services.AddDbContext<EscuelaContext>(
                options => options.UseSqlServer(connString)
            );*/

            //Inyectamos la conexión a la base de datos PostgreSQL
            string connString = ConfigurationExtensions.GetConnectionString(this.Configuration, "DefaultConnectionPostgreSQL");
            services.AddDbContext<EscuelaContext>(
                options => options.UseNpgsql(connString)
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Escuela}/{action=Index}/{id?}");
            });
        }
    }
}
