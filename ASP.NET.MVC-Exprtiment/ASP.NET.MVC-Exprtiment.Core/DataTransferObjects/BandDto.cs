using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.MVC_Exprtiment.Core.DataTransferObjects
{
    public class BandDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public DateTime DateOfCreation { get; set; }
        public string Description { get; set; }
        public string MainText { get; set; }
        public Guid LabelId { get; set; }
    }
}
