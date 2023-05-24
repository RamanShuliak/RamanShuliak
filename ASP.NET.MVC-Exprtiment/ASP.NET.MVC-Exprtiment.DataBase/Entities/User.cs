namespace ASP.NET.MVC_Exprtiment.DataBase.Entities
{
    public class User : IBaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public DateTime DateOfRegistration { get; set; }

        public virtual List<Comment>? Comments { get; set; }
    }
}