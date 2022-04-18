using Microsoft.EntityFrameworkCore;
using AppWebPractica.Data;

namespace AppWebPractica
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }


        public void ConfigureServices(IServiceCollection service)
        {
            service.AddControllersWithViews();


            service.AddDbContext<Contexto>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("StringConexion")));

            service.AddScoped<Contexto>();


        }

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

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllerRoute(
                name: "default", pattern:"{controller=Home}/{action=Index}/{id?}" 
                ); });
        }
    }
}
