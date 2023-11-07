using Confluent.Kafka;
using KafkaTest.MessageUpdateService.KafkaConfig;
using KafkaTest.MessageUpdateService.KafkaConfig.Abstractions;

namespace KafkaTest.MessageUpdateService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddTransient<IConsumer, Consumer>();
            builder.Services.AddSingleton<IConsumer<Ignore, string>>(sp =>
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

                var consumer = new ConsumerBuilder<Ignore, string>(consumerConfig).Build();
                consumer.Subscribe("send-message-1");
                return consumer;
            });

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