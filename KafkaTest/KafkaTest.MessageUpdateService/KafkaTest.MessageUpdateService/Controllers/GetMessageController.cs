using Confluent.Kafka;
using KafkaTest.MessageUpdateService.KafkaConfig.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Confluent.Kafka.ConfigPropertyNames;

namespace KafkaTest.MessageUpdateService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetMessageController : ControllerBase
    {
        private readonly IConsumer _consumer;

        public GetMessageController(IConsumer consumer)
        {
            _consumer = consumer;
        }

        [HttpPost]
        public async Task<IActionResult> GetLastMessage()
        {
            try
            {
                var messageModel = _consumer.GetLastMessage();

                return Ok(messageModel);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
