namespace KafkaTest.Models
{
    public class CreateUserModel : IBaseModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfCreation { get; set; }
    }
}