using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SEProje.ToDo.Web.Middlewares;
using Microsoft.AspNetCore.Routing.Constraints;
using SEProje.ToDo.Web.Constraints;

namespace SEProje.ToDo.Web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSession();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseCustomStaticFiles();

            app.UseRouting();

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area}/{controller=Home}/{action=Index}/{id?}"
                    );

                //endpoints.MapAreaControllerRoute(
                //    name: "areaAdmin",
                //    areaName: "Admin",
                //    pattern: "{area}/{controller}/{action}"
                //    );

                endpoints.MapControllerRoute(
                    name: "programlamaRoute",
                    pattern: "programlama/{dil}",
                    defaults: new { controller = "Home", action = "Index" },
                    constraints: new { dil = new Programlama() }
                    );

                endpoints.MapControllerRoute(
                    name: "kisi",
                    pattern: "kisiler",
                    defaults: new { controller = "Home", action = "Index" }
                    );
           
                endpoints.MapControllerRoute(
                    name: "default",
                    //pattern: "{controller=Home}/{action=Index}/{id:int?}"
                    pattern: "{controller=Home}/{action=Index}/{id?}",
                    constraints: new { id = new IntRouteConstraint() }
                );
            });
        }
    }
}
