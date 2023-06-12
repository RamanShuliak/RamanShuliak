namespace WebApiExperiment.Models.Requests
{
    public class AddBandsRequestModel
    {
        public string? Name { get; set; }
        public string? Country { get; set; }
        public DateTime? DateOfCreation { get; set; }
        public string? Description { get; set; }
        public string? MainText { get; set; }
    }
}
