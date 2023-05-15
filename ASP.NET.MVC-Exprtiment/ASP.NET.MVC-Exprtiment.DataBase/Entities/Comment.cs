namespace ASP.NET.MVC_Exprtiment.DataBase.Entities
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string? Text { get; set; }
        public DateTime PublicationDate { get; set; }

        public Guid BandId { get; set; }
        public virtual Band Band { get; set; }

        public Guid UserId { get; set; }
        public virtual User User { get; set; }

    }
}