using ASP.NET.MVC_Exprtiment.Business.ServicesImplementation;
using ASP.NET.MVC_Exprtiment.Core;
using ASP.NET.MVC_Exprtiment.Core.Abstractions;
using ASP.NET.MVC_Exprtiment.Data.Abstractions;
using ASP.NET.MVC_Exprtiment.Data.Abstractions.Repositories;
using ASP.NET.MVC_Exprtiment.Data.Repositories;
using ASP.NET.MVC_Exprtiment.DataBase;
using ASP.NET.MVC_Exprtiment.DataBase.Entities;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using Serilog;
using Serilog.Events;

namespace ASP.NET.MVC_Exprtiment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Host.UseSerilog((ctx, lc) =>
            lc.WriteTo.File(
                @"D:\Programming\ASP.NET.MVC-Exprtiment\Logs\data.log", 
                Serilog.Events.LogEventLevel.Information)
                .WriteTo.Console(LogEventLevel.Verbose));

            var connectionString = builder.Configuration.GetConnectionString("Default");

            builder.Services.AddDbContext<MusicBandsContext>(
                optionBuilder => optionBuilder.UseSqlServer(connectionString));

            // Add services to the container.
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            builder.Services.AddControllersWithViews();
            builder.Services.AddTransient<IBandService, BandService>();
            builder.Services.AddTransient<ILabelService, LabelService>();
            builder.Services.AddScoped<IRepository<Band>, BandRepository>();
            builder.Services.AddScoped<IRepository<Label>, Repository<Label>>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

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