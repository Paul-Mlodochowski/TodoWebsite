using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using TodoWebsite.Data;
using TodoWebsite.Services;

namespace TodoWebsite
{
    public class Startup
    {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services) {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddDbContext<TodoDatabaseContex>();
            

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            app.UseExceptionHandler(appBuilder =>
            {
                appBuilder.Run(async contex =>
                {
                    var logger = contex.RequestServices.GetRequiredService<ILogger<Startup>>();
                    var feature = contex.Features.Get<IExceptionHandlerFeature>();
                    if(feature.Error is not null) {
                        logger.LogError(feature.Error, "Exception");
                        contex.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        contex.Response.ContentType = "application/json";
                        await contex.Response.WriteAsync(System.Text.Json.JsonSerializer.Serialize(
                            new
                            {
                                error = "sth went wrong",
                                detail = feature.Error.Message
                            }
                            ));
                    }
                });
                
            });
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }
            else {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
