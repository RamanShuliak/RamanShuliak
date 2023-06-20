namespace WebApiExperiment.Models.Responses
{
    public class TokenResponce
    {
        public string AccessToken { get; set; }
        public string Role { get; set; }
        public Guid UserId { get; set; }
        public DateTime TokenExpiration { get; set; }
    }
}
