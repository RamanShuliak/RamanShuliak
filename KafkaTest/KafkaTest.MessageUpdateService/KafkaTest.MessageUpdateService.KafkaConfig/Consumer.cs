using Confluent.Kafka;
using KafkaTest.MediatR.Commands;
using KafkaTest.MessageUpdateService.KafkaConfig.Abstractions;
using KafkaTest.Models;
using KafkaTest.Models.Models;
using Newtonsoft.Json;

namespace KafkaTest.MessageUpdateService.KafkaConfig
{
    public class Consumer : IConsumer
    {
        private readonly IConsumer<string, string> consumer;
        private readonly ModelDictionary modelDictionary;

        public Consumer(IConsumer<string, string> consumer, ModelDictionary modelDictionary)
        {
            this.consumer = consumer;
            this.modelDictionary = modelDictionary;
        }

        public CreateUserModel GetLastMessage()
        {
            var cr = consumer.Consume();

            if (cr.Message == null)
            {
                throw new Exception("The are no messages yet.");
            }

            var modelType = modelDictionary.GetModelType(cr.Key);

            var userModel = JsonConvert.DeserializeObject<modelType>(cr.Message.Value);

            //var deserializeMethod = typeof(JsonConvert)
            //    .GetMethod("DeserializeObject")
            //    .MakeGenericMethod(modelType);

            //var userModel = deserializeMethod.Invoke(null, new[] { cr.Message.Value });

            return userModel;
        }
    }
}