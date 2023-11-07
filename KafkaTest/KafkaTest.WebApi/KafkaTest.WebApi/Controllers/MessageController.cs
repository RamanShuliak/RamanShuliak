using KafkaTest.KafkaConfig.Abstractions;
using KafkaTest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KafkaTest.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IProducer _producer;

        public MessageController(IProducer producer)
        {
            _producer = producer;
        }

        [HttpPost]
        public async Task<IActionResult> SendMessageToAnotherService(string messageText)
        {
            try
            {
                var messageModel = new MessageModel()
                {
                    Id = Guid.NewGuid(),
                    Text = messageText,
                    DateOfCreation = DateTime.UtcNow,
                };

                await _producer.SendMessageAsync("send-message-1", messageModel);

                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
