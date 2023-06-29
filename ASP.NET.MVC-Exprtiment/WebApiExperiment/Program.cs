using ASP.NET.MVC_Exprtiment.Business.ServicesImplementation;
using ASP.NET.MVC_Exprtiment.Core.Abstractions;
using ASP.NET.MVC_Exprtiment.Data.Abstractions.Repositories;
using ASP.NET.MVC_Exprtiment.Data.Abstractions;
using ASP.NET.MVC_Exprtiment.Data.Repositories;
using ASP.NET.MVC_Exprtiment.DataBase;
using ASP.NET.MVC_Exprtiment.DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Serilog;
using Serilog.Events;
using Hangfire;
using Hangfire.SqlServer;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using WebApiExperiment.Utils;
using MediatR;
using System.Net.NetworkInformation;
using ASP.NET.MVC_Exprtiment.Data.CQS.Commands;
using ASP.NET.MVC_Exprtiment.Data.CQS.Handlers.CommandHandlers;
using ASP.NET.MVC_Exprtiment.Data.CQS.Queries;
using ASP.NET.MVC_Exprtiment.Data.CQS.Handlers.QueryHandlers;
using System.Reflection;
using Microsoft.AspNetCore.Hosting;
using ASP.NET.MVC_Exprtiment.Core.DataTransferObjects;

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
            builder.Services.AddScoped<IJwtUtil, JwtUtil>();

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



            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options =>
            {
                options.IncludeXmlComments(builder.Configuration["XmlDoc"]);
            });

            builder.Services
                .AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(opt =>
                {
                    opt.RequireHttpsMetadata = false;
                    opt.SaveToken = true;
                    opt.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidIssuer = builder.Configuration["Token:Issuer"],
                        ValidAudience = builder.Configuration["Token:Issuer"],
                        IssuerSigningKey = new SymmetricSecurityKey(
                            Encoding.UTF8.GetBytes(builder.Configuration["Token:JwtSecret"])),
                        ClockSkew = TimeSpan.Zero
                    };
                });

            var app = builder.Build();

            app.UseStaticFiles();
            app.UseHangfireDashboard();
            app.UseRouting();

            app.UseSwagger();
            app.UseSwaggerUI();
            app.MapHangfireDashboard();

            app.UseHttpsRedirection();

            app.UseAuthentication();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}