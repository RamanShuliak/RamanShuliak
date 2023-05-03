﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.MVC_Exprtiment.Core.DataTransferObjects
{
    public class BandDto
    {
        public Guid Id { get; set; }
        public string BandName { get; set; }
        public string Country { get; set; }
        public DateTime DateOfCreation { get; set; }
        public string MainInformation { get; set; }
    }
}
