using Confluent.Kafka;
using KafkaTest.KafkaConfig.Abstractions;
using System.Diagnostics;
using System.Net;

namespace KafkaTest.KafkaConfig
{
    public class Producer : IProducer
    {
        private readonly KafkaConfigurations _kafkaConfiguration;

        public Producer(KafkaConfigurations kafkaConfiguration)
        {
            _kafkaConfiguration = kafkaConfiguration;
        }

        public async Task SendMessageAsync(string topic, string message)
        {
            ProducerConfig config = new ProducerConfig
            {
                BootstrapServers = _kafkaConfiguration.KafkaAddress
            };

            using (var producer = new ProducerBuilder<Null, string>(config).Build())
            {
                var result = await producer.ProduceAsync
                (topic, new Message<Null, string>
                {
                    Value = message
                });
            }
        }
    }
}