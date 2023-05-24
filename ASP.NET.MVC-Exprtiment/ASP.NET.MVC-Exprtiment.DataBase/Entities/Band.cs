namespace ASP.NET.MVC_Exprtiment.DataBase.Entities
{
    public class Band : IBaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Country { get; set; }
        public DateTime? DateOfCreation { get; set; }
        public string? Description { get; set; }
        public string? MainText { get; set; }

        public Guid? LabelId { get; set; }
        public virtual Label? Label { get; set; }

        public virtual List<Comment>? Comments { get; set; }
    }
}