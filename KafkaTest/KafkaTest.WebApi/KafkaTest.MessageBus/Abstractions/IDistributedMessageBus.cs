using KafkaTest.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafkaTest.MessageBus.Abstractions
{
    public interface IDistributedMessageBus
    {
        Task PublishEventAsync(IEvent @event, string modelName);
    }
}
