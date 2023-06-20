﻿using System.ComponentModel.DataAnnotations;

namespace WebApiExperiment.Models.Requests
{
    public class LoginRequestModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]  
        public string Password { get; set; }

    }
}
