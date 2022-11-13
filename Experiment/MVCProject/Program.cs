using Microsoft.EntityFrameworkCore;
using MVCProject.Business.ServicesImplementation;
using MVCProject.Core;
using MVCProject.Core.Abstractions;
using MVCProject.DataBase;

namespace MVCProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            // Add services to the container.
            var builder = WebApplication.CreateBuilder(args);

            var connectionString = builder.Configuration.GetConnectionString("Default");
            /*  "Server=HPPROBOOK;" +
                "Database=GoodNewsAggregatorDataBase;" +
                "Trusted_Connection=True;" +
                "TrustServerCertificate=True";

            // Add services to the container.
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<GoodNewsAggregatorContext>(optionsBuilder =>
            optionsBuilder.UseSqlServer(connectionString));
            builder.Services.AddTransient<IArticleService, ArticleService>();
/*            builder.Services.AddSingleton<ArticleStorage>();*/

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