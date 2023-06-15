using System.ComponentModel.DataAnnotations;

namespace WebApiExperiment.Models.Requests
{
    public class RegisterRequestModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]  
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string PasswordConfirmation { get; set; }

    }
}
