using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TantosHousingProject.Database;
using TantosHousingProject.Models.Service;
using TantosHousingProject.Models.Repo;
using TantosHousingProject.Models.Data;

namespace TantosHousingProject
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
            //----------------- connection to database--------------------
            services.AddDbContext<THPDbContext>(options => options.
            UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));


            //----------------- Identity -------------------------------
            services.AddIdentity<IdentityUser, IdentityRole>()
                    .AddEntityFrameworkStores<THPDbContext>()
                    .AddDefaultTokenProviders();

            services.ConfigureApplicationCookie(options =>
            {
                options.AccessDeniedPath = "/Account/AccessDenied";
            });

            //---------------- services IOC ----------------------------
            services.AddScoped<IRoomService, RoomService>();
            services.AddScoped<ITenantService, TenantService>();
            services.AddScoped<IHousekeeperService, HousekeeperService>();
            services.AddScoped<IContractService, ContractService>();

            //----------------- repo IOC -------------------------------
            services.AddScoped<IGenericRepo<Room>, RoomRepo>();
            services.AddScoped<IGenericRepo<Tenant>, TenantRepo>();
            services.AddScoped<IGenericRepo<Housekeeper>, HousekeeperRepo>();
            services.AddScoped<IGenericRepo<Contract>, ContractRepo>();


            services.AddMvc();
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

                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();


            app.UseAuthentication();//  Add this
            app.UseAuthorization();//  Add this too
        
        

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
