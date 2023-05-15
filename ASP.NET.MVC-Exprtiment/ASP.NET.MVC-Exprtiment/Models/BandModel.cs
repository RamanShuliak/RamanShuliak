﻿using System.ComponentModel.DataAnnotations;

namespace ASP.NET.MVC_Exprtiment.Models
{
    public class BandModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfCreation { get; set; }

        public string Label { get; set; }
        public string Description { get; set; }
        public string MainText { get; set; }

    }
}
