using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Amazon.Models;
using Microsoft.EntityFrameworkCore;

namespace Amazon
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration["Data:AmazonStoreDB:ConnectionString"]));
            services.AddTransient<IBookRepository, EFBookRepository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            /* if (env.IsDevelopment())
             {                
                 app.UseDeveloperExceptionPage(); // solo para el entorno de desarrollo no para produccion
                 app.UseStaticFiles(new StaticFileOptions() // Proveer WWROOT para usar con el nombre /vendor
                 {
                     FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"node_modules")),
                     RequestPath = new PathString("/vendor")
                 });
             }
             else
             {
                 app.UseExceptionHandler("/Home/Error");
                 app.UseHsts();
             }*/

            //app.UseHttpsRedirection();
            //app.UseStaticFiles();
            //app.UseCookiePolicy();

            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "default", 
                    template: "{controller=Book}/{action=List}/{id?}");
            });
            app.UseStaticFiles(new StaticFileOptions() // Proveer WWROOT para usar con el nombre /vendor
            {
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(), 
                    @"node_modules")),
                RequestPath = new PathString("/vendor")
            });
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                name: null,
                template: "{category}/Page{bookPage:int}",
                defaults: new { controller = "Book", action = "List" });
                routes.MapRoute(
                name: null,
                template: "Page{bookPage:int}",
                defaults: new { controller = "Book", action = "List", bookPage = 1 });
                routes.MapRoute(
                name: null,
                template: "{category}",
                defaults: new { controller = "Book", action = "List", bookPage = 1 });
                routes.MapRoute(
                name: null,
                template: "",
                defaults: new { controller = "Book", action = "List", bookPage = 1 });
                routes.MapRoute(
                name: null,
                template: "{controller}/{action}/{id?}");
            });
            SeedData.EnsurePopulated(app);
        }
    }
}