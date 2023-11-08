using KafkaTest.MediatR.Abstractions;
using KafkaTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafkaTest.MessageBus.Abstractions
{
    public interface ILocalMessageBus
    {
        Task SendCommandAsync(ICommand command);
        Task<IBaseModel> SendQueryAsync(IQuery query);
    }
}
