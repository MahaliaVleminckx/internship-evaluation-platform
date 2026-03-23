using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Web.Data;
using Howest.SelfEvaluation.Web.Services;
using Howest.SelfEvaluation.Web.Services.Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Howest.SelfEvaluation.Web
{
    public class Program
    {
        public static void Main(string[] args)  
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services
                .AddDbContext<SelfEvaluationsContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("EvaluationDb")));
            builder.Services.AddControllersWithViews();

            //custom dependency injections
            builder.Services.AddTransient<IEvaluationService, EvaluationService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            //custom routes
            app.MapControllerRoute(
                name: "Evaluations",
                pattern: "Evaluations/Index/{username}",
                defaults: new { Controller = "Evaluations", Action = "Index" }
            );

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}