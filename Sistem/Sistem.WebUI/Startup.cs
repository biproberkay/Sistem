using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Sistem.Core.Abstract.DaInterfaces;
using Sistem.Core.Abstract.ServiceInterfaces;
using Sistem.Core.Entities;
using Sistem.Infrastructure.Concrete.DataAccess.MemoryDa;
using Sistem.Infrastructure.Concrete.Managers;

namespace Sistem.WebUI
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
            /** entityler için addscope foreach döndürmek
            List<T> Ts = new List<T>();

            foreach (var T in Ts)
            {
                services.AddScoped<IServiceRepository<T>, ManagerRepository<T>>();
                services.AddScoped<IDaRepository<T>, MemoryDaRepository<T>>();
            }
            */

            services.AddScoped<IServiceRepository<Yer>, ManagerRepository<Yer>>();
            services.AddScoped<IDaRepository<Yer>, YerMemoryDal>();

            services.AddScoped<IServiceRepository<TextLog>, ManagerRepository<TextLog>>();
            services.AddScoped<IDaRepository<TextLog>, TLogMemoryDal>();

            services.AddScoped<IServiceRepository<PictureLog>, ManagerRepository<PictureLog>>();
            services.AddScoped<IDaRepository<PictureLog>, PLogMemoryDal>();

            services.AddControllersWithViews();
            services.AddMvc(options => options.EnableEndpointRouting = false);
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

            app.UseRouting();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "AreaRoute",
                    template: "{area:exists}/{controller}/{action}/{id?}/{title?}",
                    defaults: new { controller = "Home", action = "Index" });

                routes.MapRoute(
                    name: "defaut",
                    template: "{controller=Home}/{action=Index}/{id?}"
                    );

            });
        }
    }
}
