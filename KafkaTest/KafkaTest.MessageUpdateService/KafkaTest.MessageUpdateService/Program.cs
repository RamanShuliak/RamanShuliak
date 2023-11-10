using Confluent.Kafka;
using KafkaTest.DataBase;
using KafkaTest.MediatR.Commands;
using KafkaTest.MediatR.Handlers.CommandHandlers;
using KafkaTest.MessageUpdateService.KafkaConfig;
using KafkaTest.MessageUpdateService.KafkaConfig.Abstractions;
using KafkaTest.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KafkaTest.MessageUpdateService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var connectionString = builder.Configuration.GetConnectionString("Default");

            builder.Services.AddDbContext<KafkaTestDbContext>(
                            optionBuilder => optionBuilder.UseSqlServer(connectionString));

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            builder.Services.AddTransient<IConsumer, Consumer>();
            builder.Services.AddScoped<ModelDictionary>();
            builder.Services.AddSingleton<IConsumer<string, string>>(sp =>
            {
                var consumerConfig = new ConsumerConfig
                {
                    BootstrapServers = "localhost:29092",
                    GroupId = "message-group",
                    EnableAutoOffsetStore = false,
                    EnableAutoCommit = true,
                    StatisticsIntervalMs = 5000,
                    SessionTimeoutMs = 6000,
                    AutoOffsetReset = AutoOffsetReset.Earliest,
                    EnablePartitionEof = true,
                    PartitionAssignmentStrategy = PartitionAssignmentStrategy.CooperativeSticky
                };

                var consumer = new ConsumerBuilder<string, string>(consumerConfig).Build();
                consumer.Subscribe("publish-event-3");
                return consumer;
            });

            // Add MediatR services
            builder.Services
                .AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<Program>());
            builder.Services
                .AddScoped<IRequestHandler<CreateUserCommand>, CreateUserCommandHandler>();

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