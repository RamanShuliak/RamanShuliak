using ASP.NET.MVC_Exprtiment.Business.ServicesImplementation;
using ASP.NET.MVC_Exprtiment.Core;
using ASP.NET.MVC_Exprtiment.Core.Abstractions;
using ASP.NET.MVC_Exprtiment.Core.DataTransferObjects;
using ASP.NET.MVC_Exprtiment.Data.Abstractions;
using ASP.NET.MVC_Exprtiment.Data.Abstractions.Repositories;
using ASP.NET.MVC_Exprtiment.Data.CQS.Commands;
using ASP.NET.MVC_Exprtiment.Data.CQS.Handlers.CommandHandlers;
using ASP.NET.MVC_Exprtiment.Data.CQS.Handlers.QueryHandlers;
using ASP.NET.MVC_Exprtiment.Data.CQS.Queries;
using ASP.NET.MVC_Exprtiment.Data.Repositories;
using ASP.NET.MVC_Exprtiment.DataBase;
using ASP.NET.MVC_Exprtiment.DataBase.Entities;
using MediatR;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using Serilog;
using Serilog.Events;
using System.Net.NetworkInformation;
using System.Reflection;

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

            builder.Services.AddControllersWithViews();

            builder.Configuration.AddJsonFile("secret.json");

            builder.Services
                .AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.ExpireTimeSpan = TimeSpan.FromHours(1);
                    options.LoginPath = new PathString(@"/Account/Login");
                });


            builder.Services
                .AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

            // Add services to the container.
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            builder.Services.AddTransient<IBandService, BandService>();
            builder.Services.AddTransient<ILabelService, LabelService>();
            builder.Services.AddTransient<IUserService, UserService>();
            builder.Services.AddTransient<IRoleService, RoleService>();
            builder.Services.AddScoped<IRepository<Band>, BandRepository>();
            builder.Services.AddScoped<IRepository<Label>, Repository<Label>>();
            builder.Services.AddScoped<IRepository<User>, Repository<User>>();
            builder.Services.AddScoped<IRepository<Role>, Repository<Role>>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

            // Add MediatR services
            builder.Services
                .AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<Program>());
            builder.Services
                .AddScoped<IRequestHandler<AddBandAsyncCommand>, AddBandAsyncCommandHandler>();
            builder.Services
                .AddScoped<IRequestHandler<AddRefreshTokenCommand>, AddRefreshTokenCommandHandler>();
            builder.Services
                .AddScoped<IRequestHandler<GetBandByIdQuery, Band>, GetBandByIdQueryHandler>();
            builder.Services
                .AddScoped<IRequestHandler<GetUserByRefreshTokenQuery, UserDto?>, GetUserByRefreshTokenQueryHandler>();
            builder.Services
                .AddScoped<IRequestHandler<RemoveRefreshTokenCommand>, RemoveRefreshTokenCommandHandler>();

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

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}