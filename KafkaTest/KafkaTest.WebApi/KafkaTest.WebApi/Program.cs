
using KafkaTest.DataBase;
using KafkaTest.KafkaConfig;
using KafkaTest.KafkaConfig.Abstractions;
using KafkaTest.MediatR.Abstractions;
using KafkaTest.MediatR.Commands;
using KafkaTest.MediatR.Handlers.CommandHandlers;
using KafkaTest.MediatR.Handlers.QueryHandlers;
using KafkaTest.MediatR.Queries;
using KafkaTest.MessageBus.Abstractions;
using KafkaTest.MessageBus.Distributed;
using KafkaTest.MessageBus.Local;
using KafkaTest.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KafkaTest.WebApi
{
    public class Program
    {
        private IConfiguration Configuration { get; }
        public Program(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var connectionString = builder.Configuration.GetConnectionString("Default");

            builder.Services.AddDbContext<KafkaTestDbContext>(
                            optionBuilder => optionBuilder.UseSqlServer(connectionString));

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            builder.Services.AddScoped<IProducer, Producer>();
            builder.Services.AddScoped<KafkaConfigurations>();
            builder.Services.AddScoped<ILocalMessageBus, LocalMessageBus>();
            builder.Services.AddScoped<IDistributedMessageBus, DistributedMessageBus>();

            // Add MediatR services
            builder.Services
                .AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<Program>());
            builder.Services
                .AddScoped<IRequestHandler<CreateUserCommand>, CreateUserCommandHandler>();
            builder.Services
                .AddScoped<IRequestHandler<GetUserByIdQuery, IBaseModel>, GetUserByIdQueryHandler>();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}