using Confluent.Kafka;
using KafkaTest.MessageUpdateService.KafkaConfig.Abstractions;
using KafkaTest.Models;
using Newtonsoft.Json;

namespace KafkaTest.MessageUpdateService.KafkaConfig
{
    public class Consumer : IConsumer
    {
        private readonly IConsumer<Ignore, string> _consumer;

        public Consumer(IConsumer<Ignore, string> consumer)
        {
            _consumer = consumer;
        }

        public MessageModel GetLastMessage()
        {
            var cr = _consumer.Consume();

            if (cr.Message == null)
            {
                throw new Exception("The are no messages yet.");
            }

            var messageModel = JsonConvert.DeserializeObject<MessageModel>(cr.Value);

            return messageModel;
        }
    }
}