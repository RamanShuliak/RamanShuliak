using Confluent.Kafka;
using KafkaTest.MediatR.Commands;
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

        public UserModel GetLastMessage()
        {
            var cr = _consumer.Consume();

            if (cr.Message == null)
            {
                throw new Exception("The are no messages yet.");
            }

            var userModel = JsonConvert.DeserializeObject<UserModel>(cr.Message.Value);

            return userModel;
        }
    }
}