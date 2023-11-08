namespace KafkaTest.Models
{
    public class UserModel : IBaseModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfCreation { get; set; }
    }
}