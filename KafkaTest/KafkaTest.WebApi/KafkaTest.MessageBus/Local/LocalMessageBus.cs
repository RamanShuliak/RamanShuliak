using KafkaTest.MediatR.Abstractions;
using KafkaTest.MessageBus.Abstractions;
using KafkaTest.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafkaTest.MessageBus.Local
{
    public class LocalMessageBus : ILocalMessageBus
    {
        private readonly IMediator mediator;

        public LocalMessageBus(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task SendCommandAsync(ICommand command)
        {
            await mediator.Send(command);
        }

        public async Task<IBaseModel> SendQueryAsync(IQuery query)
        {
            var model = await mediator.Send(query);

            return model;
        }
    }
}
