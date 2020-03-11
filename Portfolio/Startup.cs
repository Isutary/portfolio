using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using Portfolio.Models;

namespace Portfolio
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<PortfolioDbContext>(options => options.UseMySql(Configuration["Data:PortfolioDb:ConnectionString"]));
            services.AddDbContext<PortfolioIdentityDbContext>(options => options.UseMySql(Configuration["Data:PortfolioDbIdentity:ConnectionString"]));
            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<PortfolioIdentityDbContext>().AddDefaultTokenProviders();
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "",
                    template: "{controller=home}/{action=home}"
                    );
            });
            //DbInitializer.EnsurePopulated(app);
            //IdentitySeedData.EnsurePopulated(app);

        }
    }
}
