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
        Task SendMessageAsync(string topic, IBaseMessage message);
    }
}
