using KafkaTest.Events;
using KafkaTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafkaTest.KafkaConfig.Abstractions
{
    public interface IProducer
    {
        Task PublishEventAsync(string topic, IEvent @event, string modelName);
    }
}
