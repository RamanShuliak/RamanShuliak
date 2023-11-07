namespace KafkaTest.Models
{
    public class MessageModel : IBaseMessage
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public DateTime DateOfCreation { get; set; }
    }
}