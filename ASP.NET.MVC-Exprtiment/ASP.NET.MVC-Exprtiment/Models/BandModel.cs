using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace ASP.NET.MVC_Exprtiment.Models
{
    public class BandModel
    {
        public Guid Id { get; set; }

        [Required]
        [Remote("CheckName", "Band",
            HttpMethod = WebRequestMethods.Http.Post, 
            ErrorMessage = "Band with this name is already exist.")]
        public string Name { get; set; }
        public string Country { get; set; }
        public DateTime DateOfCreation { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public string MainText { get; set; }

    }
}
