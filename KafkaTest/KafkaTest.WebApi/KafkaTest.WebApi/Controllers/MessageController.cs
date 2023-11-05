using KafkaTest.KafkaConfig.Abstractions;
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
        public async Task<IActionResult> SendMessageToAnotherService(string message)
        {
            try
            {
                await _producer.SendMessageAsync("send-message", message);

                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
