using ASP.NET.MVC_Exprtiment.Business.ServicesImplementation;
using ASP.NET.MVC_Exprtiment.Core.Abstractions;
using ASP.NET.MVC_Exprtiment.Data.Abstractions.Repositories;
using ASP.NET.MVC_Exprtiment.Data.Abstractions;
using ASP.NET.MVC_Exprtiment.Data.Repositories;
using ASP.NET.MVC_Exprtiment.DataBase;
using ASP.NET.MVC_Exprtiment.DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Serilog.Events;
using Hangfire;
using Hangfire.SqlServer;
using Microsoft.Extensions.Configuration;

namespace WebApiExperiment
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

            builder.Services.AddControllers();

            var connectionString = builder.Configuration.GetConnectionString("Default");

            builder.Services.AddDbContext<MusicBandsContext>(
                optionBuilder => optionBuilder.UseSqlServer(connectionString));

            // Add Hangfire services.
            builder.Services.AddHangfire(configuration => configuration
                .SetDataCompatibilityLevel(CompatibilityLevel.Version_180)
                .UseSimpleAssemblyNameTypeSerializer()
                .UseRecommendedSerializerSettings()
                .UseSqlServerStorage(connectionString));

            builder.Services.AddHangfireServer();

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

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options =>
            {
                options.IncludeXmlComments(builder.Configuration["XmlDoc"]);
            });

            var app = builder.Build();

            app.UseStaticFiles();
            app.UseHangfireDashboard();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();
            app.MapHangfireDashboard();

            app.Run();
        }
    }
}