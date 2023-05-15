namespace ASP.NET.MVC_Exprtiment.DataBase.Entities
{
    public class Label
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }
        public virtual List<Band>? Bands { get; set; }
    }
}