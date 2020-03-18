using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Sistem.Core.Abstract.DalInterfaces;
using Sistem.Core.Abstract.ServiceInterfaces;
using Sistem.Core.Entities;
using Sistem.Infrastructure.Concrete.DataAccess.EfCoreDal;
using Sistem.Infrastructure.Concrete.DataAccess.MemoryDal;
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
                services.AddScoped<IDalRepository<T>, MemoryDaRepository<T>>();
            }
            */

            //services.AddScoped<IServiceRepository<Yer>, ManagerRepository<Yer>>();
            //services.AddScoped<IDalRepository<Yer>, EfCoreDalRepository<Yer>>();
            services.AddScoped<IYerService, YerManager>();
            services.AddScoped<IYerDal, EfCoreYerDal>();

            //services.AddScoped<IDalRepository<Post>, MemoryPostDa>();
            //services.AddScoped<IServiceRepository<Post>, ManagerRepository<Post>>();
            //services.AddScoped<IDalRepository<Post>, EfCoreDalRepository<Post>>();
            services.AddScoped<IPostService, PostManager>();
            services.AddScoped<IPostDal, EfCorePostDal>();

            services.AddScoped<IServiceRepository<TextLog>, ManagerRepository<TextLog>>();
            services.AddScoped<IDalRepository<TextLog>, TLogMemoryDal>();

            services.AddScoped<IServiceRepository<PictureLog>, ManagerRepository<PictureLog>>();
            services.AddScoped<IDalRepository<PictureLog>, PLogMemoryDal>();


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
            /** custom middleware için
            // Serve my app-specific default file, if present.
            DefaultFilesOptions options = new DefaultFilesOptions();
            options.DefaultFileNames.Clear();
            options.DefaultFileNames.Add("/MyStaticFiles/main/index.html");
            app.UseDefaultFiles(options);
            app.UseStaticFiles();//for wwwroot
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(), "MyStaticFiles")),
                RequestPath = "/StaticFiles"
            });
             */

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
