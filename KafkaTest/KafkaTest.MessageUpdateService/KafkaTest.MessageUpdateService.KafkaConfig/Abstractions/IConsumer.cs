using KafkaTest.MediatR.Commands;
using KafkaTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafkaTest.MessageUpdateService.KafkaConfig.Abstractions
{
    public interface IConsumer
    {
        UserModel GetLastMessage();
    }
}