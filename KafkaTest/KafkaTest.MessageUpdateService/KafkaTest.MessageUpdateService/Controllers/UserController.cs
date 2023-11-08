using Confluent.Kafka;
using KafkaTest.MediatR.Commands;
using KafkaTest.MessageUpdateService.KafkaConfig.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Confluent.Kafka.ConfigPropertyNames;

namespace KafkaTest.MessageUpdateService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IConsumer consumer;
        private readonly IMediator mediator;

        public UserController(IConsumer consumer, IMediator mediator)
        {
            this.consumer = consumer;
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateNewUser()
        {
            try
            {
                var userModel = consumer.GetLastMessage();

                await mediator.Send(new CreateUserCommand()
                {
                    UserModel = userModel
                });

                return Ok(userModel);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
