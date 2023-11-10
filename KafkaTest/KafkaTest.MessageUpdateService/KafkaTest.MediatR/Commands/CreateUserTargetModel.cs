using KafkaTest.Models;
using MediatR;

namespace KafkaTest.MediatR.Commands
{
    [ModelName("CreateUserTargetModel")]
    public class CreateUserTargetModel : IRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfCreation { get; set; }
    }
}