using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.Exprtiments.EF
{
    public class Label
    {
        public int Id { get; set; }
        public string LabelName { get; set; }

        public virtual List<Band> Bands { get; set; }

    }
}
