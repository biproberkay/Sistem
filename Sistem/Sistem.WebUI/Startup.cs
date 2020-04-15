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
using Sistem.Core.Abstract.DaInterfaces;
using Sistem.Core.Abstract.ServiceInterfaces;
using Sistem.Core.Entities;
using Sistem.Infrastructure.Concrete.DataAccess.EfCoreDa;
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
            services.AddDbContext<EfCoreSistemContext>();

            //services.AddScoped<IDaRepository<Yer>, MemoryYerDa>();
            services.AddScoped<IServiceRepository<Yer>, ManagerRepository<Yer>>();
            services.AddScoped<IDaRepository<Yer>, EfCoreDaRepository<Yer>>();
            services.AddScoped<IServiceYer, YerManager>();
            services.AddScoped<IDaYer, EfCoreYerDa>();

            //services.AddScoped<IDaRepository<Post>, MemoryPostDa>();
            services.AddScoped<IServiceRepository<Post>, ManagerRepository<Post>>();
            services.AddScoped<IDaRepository<Post>, EfCoreDaRepository<Post>>();
            services.AddScoped<IPostService, PostManager>();
            services.AddScoped<IPostDal, EfCorePostDal>();

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
                /**
                 */
                routes.MapRoute(
                  name: "posts",
                  template: "posts/{yerId?}",
                  defaults: new { area="Blog", controller ="Post", action ="IndexWP" }
                );

                routes.MapRoute(
                    name: "defaut",
                    template: "{controller=Home}/{action=Index}/{id?}"
                    );

            });
        }
    }
}
