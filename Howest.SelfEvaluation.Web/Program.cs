using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Web.Data;
using Howest.SelfEvaluation.Web.Services;
using Howest.SelfEvaluation.Web.Services.Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileSystemGlobbing.Internal;

namespace Howest.SelfEvaluation.Web
{
    public class Program
    {
        public static void Main(string[] args)  
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services
                .AddDbContext<SelfEvaluationsDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("EvaluationDb")));
            builder.Services.AddControllersWithViews();

            //custom dependency injections
            builder.Services.AddScoped<IEvaluationService, EvaluationService>();
            builder.Services.AddScoped<IFormBuilderService, FormBuilderService>();
            builder.Services.AddScoped<IViewModelMappingService,  ViewModelMappingService>();
            builder.Services.AddScoped<IAdminUserService, AdminUserService>();

            //add session service
            builder.Services.AddSession();

            

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

            //install session
            app.UseSession();

            //custom routes

            //admin area
            app.MapControllerRoute(
                name: "AdminArea",
                pattern: "{area:exists}/{controller=Admin}/{action=Dashboard}"
                );

            app.MapControllerRoute(
                name: "AdminUpdateEvaluation",
                pattern: "Admin/CreateEvaluation/{evaluationId:guid}",
                defaults: new { Controller = "Admin", Action = "UpdateEvaluation" }
            );
            app.MapControllerRoute(
                name: "MentorShowStudents",
                pattern: "Mentor/ShowStudents/{mentorId:guid}",
                defaults: new { Controller = "Mentor", Action = "ShowStudents" }
            );

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