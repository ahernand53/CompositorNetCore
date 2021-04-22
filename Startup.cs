using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System.IO;
using Microsoft.EntityFrameworkCore;
using ytWebGentile.Data;
using ytWebGentile.Repository;

namespace ytWebGentile
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
            services.AddDbContext<BookStoreContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Default")));
            services.AddControllersWithViews();
            services.AddRazorPages().AddRazorRuntimeCompilation();
            services.AddScoped<BookRepository, BookRepository>();
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
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                /*endpoints.MapControllerRoute(
                    "Default",
                    "{controller=Home}/{action=Index}/{id?}"
                );*/
            });
        }
    }
}