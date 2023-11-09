using Confluent.Kafka;
using KafkaTest.Events;
using KafkaTest.KafkaConfig.Abstractions;
using KafkaTest.Models;
using Newtonsoft.Json;
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

        public async Task PublishEventAsync(string topic, IEvent @event, string modelName)
        {
            ProducerConfig config = new ProducerConfig
            {
                BootstrapServers = _kafkaConfiguration.KafkaAddress
            };

            var serializedEvent = JsonConvert.SerializeObject(@event);

            using (var producer = new ProducerBuilder<string, string>(config).Build())
            {
                var result = await producer.ProduceAsync
                (topic, new Message<string, string>
                {
                    Value = serializedEvent,
                    Key = modelName
                }) ;
            }
        }
    }
}