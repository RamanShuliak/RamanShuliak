namespace ASP.NET.MVC_Exprtiment.Models
{
    public class BandModel
    {
        public Guid Id { get; set; }
        public string BandName { get; set; }
        public string Country { get; set; }
        public DateTime DateOfCreation { get; set; }
        public string MainInformation { get; set; }
    }
}
