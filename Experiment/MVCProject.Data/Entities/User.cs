namespace MVCProject.DataBase.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public DateTime PublicationDate { get; set; }
        public List<Comment> Comments { get; set; }
    }
}