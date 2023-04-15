using WebApplication6.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using WebApplication6.Repository;

namespace WebApplication6
{
    public class Startup
    { 
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<ApplicationDbContext> (options => options.UseSqlServer("Server = DEEPAK-MAMTA110\\MSSQLSERVER01; Database = EmployeeData; User ID = sa; Password = admin; TrustServerCertificate = True; "));
            services.AddScoped<EmployeeRepository, EmployeeRepository>();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles();
            //app.UseStaticFiles(new StaticFileOptions()
            //{
            //    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "MyFile")),
            //    RequestPath= "/MyFile"
            //});
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
