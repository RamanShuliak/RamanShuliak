using KafkaTest.Events.Events;
using KafkaTest.KafkaConfig.Abstractions;
using KafkaTest.MediatR.Abstractions;
using KafkaTest.MediatR.Commands;
using KafkaTest.MediatR.Queries;
using KafkaTest.MessageBus.Abstractions;
using KafkaTest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KafkaTest.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ILocalMessageBus localMessageBus;
        private readonly IDistributedMessageBus distributedMessageBus;

        public UserController(ILocalMessageBus localMessageBus, IDistributedMessageBus distributedMessageBus)
        {
            this.localMessageBus = localMessageBus;
            this.distributedMessageBus = distributedMessageBus;
        }

        /// <summary>
        /// Create new user with local handler
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateNewUserWithLocalHandler(string userName)
        {
            try
            {
                var userModel = new UserModel()
                {
                    Id = Guid.NewGuid(),
                    Name = userName,
                    DateOfCreation = DateTime.UtcNow,
                };

                await localMessageBus.SendCommandAsync(new CreateUserCommand()
                {
                    UserModel = userModel
                });

                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Create new user with external handler
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateNewUserWithExternalHandler(string userName)
        {
            try
            {
                await distributedMessageBus.PublishEventAsync(new CreateUserEvent()
                {
                    Id = Guid.NewGuid(),
                    Name = userName,
                    DateOfCreation = DateTime.UtcNow
                });

                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetUserByIdWithLocalHandler(Guid id)
        {
            try
            {
                var userModel = await localMessageBus.SendQueryAsync(new GetUserByIdQuery()
                {
                    UserId = id
                });

                return Ok(userModel);
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
