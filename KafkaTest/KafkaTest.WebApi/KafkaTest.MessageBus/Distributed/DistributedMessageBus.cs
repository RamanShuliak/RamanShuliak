using KafkaTest.Events;
using KafkaTest.KafkaConfig.Abstractions;
using KafkaTest.MessageBus.Abstractions;
using KafkaTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafkaTest.MessageBus.Distributed
{
    public class DistributedMessageBus : IDistributedMessageBus
    {
        private readonly IProducer _producer;

        public DistributedMessageBus(IProducer producer)
        {
            _producer = producer;
        }

        public async Task PublishEventAsync(IEvent @event, string modelName)
        {
            await _producer.PublishEventAsync("publish-event-4", @event, modelName);
        }
    }
}
