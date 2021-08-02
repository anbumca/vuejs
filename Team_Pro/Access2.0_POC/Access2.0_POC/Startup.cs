using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityLibrary.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Proxies;
using Access2._0_POC.Services;
using Access2._0_POC.Services.IServices;
using ServiceCurrency = Access2._0_POC.Services.Currency;
using System.Reflection;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Access2._0_POC
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
            var DBHost = Environment.GetEnvironmentVariable("DBHost");
            var DBPassword = Environment.GetEnvironmentVariable("DBPassword");
            var DBUser = Environment.GetEnvironmentVariable("DBUser");
            var DatabaseName = Environment.GetEnvironmentVariable("DBName");
            var migrationsAssembly = typeof(Startup).GetTypeInfo().Assembly.GetName().Name;

            services.AddDbContext<AccessDbContext>
                (item => item.UseLazyLoadingProxies().UseSqlServer($"Server={DBHost};User Id=access;Password=Access@123;Database=AccessDB"));

            //Add all services here
            services.AddTransient<IExternalEcomSystem, ExternalEcomSystem>();
            services.AddTransient<ICurrency, ServiceCurrency>();
            services.AddTransient<ISubscriptionPlan, SubscriptionPlanService>();
            services.AddTransient<IDynamicForm, DynamicFormService>();



            //List<EntityLibrary.Context.Currency> tenant = null;

            //    services.AddOptions<CookieAuthenticationOptions>(
            //                CookieAuthenticationDefaults.AuthenticationScheme)
            //.Configure<ICurrency>((options, myService) =>
            //{
            //    var tenant = myService.Get().ToList();
            //});

            services.AddControllersWithViews()
                .AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

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

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
