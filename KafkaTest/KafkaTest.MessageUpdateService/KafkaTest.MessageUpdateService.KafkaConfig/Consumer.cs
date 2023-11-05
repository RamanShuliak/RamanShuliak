using Confluent.Kafka;
using KafkaTest.MessageUpdateService.KafkaConfig.Abstractions;

namespace KafkaTest.MessageUpdateService.KafkaConfig
{
    public class Consumer : IConsumer
    {
        private readonly IConsumer<Ignore, string> _consumer;

        public Consumer(IConsumer<Ignore, string> consumer)
        {
            _consumer = consumer;
        }

        public string GetLastMessage(string group, string topic)
        {
            var cr = _consumer.Consume();

            if (cr.Message == null)
            {
                throw new Exception("The are no messages yet.");
            }

            return cr.Value;
        }
    }
}