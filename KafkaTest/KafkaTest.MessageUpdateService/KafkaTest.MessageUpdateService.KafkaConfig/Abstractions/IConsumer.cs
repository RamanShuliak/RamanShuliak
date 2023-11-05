using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafkaTest.MessageUpdateService.KafkaConfig.Abstractions
{
    public interface IConsumer
    {
        string GetLastMessage(string group, string topic);
    }
}
