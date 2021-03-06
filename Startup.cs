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
using Assignment5.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace Assignment5
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

            services.AddDbContext<BookDBContext>(options =>
            {
                options.UseSqlite(Configuration["ConnectionStrings:BookDB"]);
            });

            //add razor pages services
            services.AddRazorPages();

            services.AddDistributedMemoryCache();
            services.AddSession();
            services.AddScoped<Cart>(sp => SessionCart.GetCart(sp));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            //adding this "trust the process" -Spencer Hilton
            services.AddScoped<IBookRepository, EFBookRepository>();
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

            //sets up a session for us 
            app.UseSession();

            //security
            app.Use(async (context, next) =>
            {
                context.Response.Headers.Add("X-Xss-Protection", "1");
                await next();
            });


            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //endpoint 1
                endpoints.MapControllerRoute(
                    "catpage",
                    "{category}/{pageNum}",
                    new { Controller = "Home", action = "Index" });

                //endpoint2
                endpoints.MapControllerRoute(
                    "page",
                    "{pageNum}",
                    new { Controller = "Home", action = "Index" });

                //endpoint3
                endpoints.MapControllerRoute(
                    "category",
                    "{category}",
                    new { Controller = "Home", action = "Index", pageNum=1 });

                //endpoint 4
                endpoints.MapControllerRoute(
                    "pagination",
                    "P{pageNum}",
                    new { Controller = "Home", action = "Index" });


                endpoints.MapDefaultControllerRoute();

                //route to razor page endpoints
                endpoints.MapRazorPages();
            });

            //This is getting the seed data for the website. We can take this code out later when we have migrated the seed data to our database
            SeedData.Blah(app); 
        }
    }
}
