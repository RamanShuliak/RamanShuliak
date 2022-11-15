using MedicalAssistantMVCProject.DataBase;
using Microsoft.EntityFrameworkCore;

namespace MedicalAssistantMVCProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var connectionString = "Server=HPPROBOOK;" +
                                   "Database=MedicalAssistantDb;" +
                                   "Trusted_Connection=True;" +
                                   "TrustServerCertificate=True;";

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<MedicalAssistantDbContext>(optionsBuilder =>
                optionsBuilder.UseSqlServer(connectionString));

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

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}