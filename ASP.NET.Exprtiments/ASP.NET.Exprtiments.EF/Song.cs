using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.Exprtiments.EF
{
    public class Song
    {
        public int Id { get; set; }
        public string SongName { get; set; }
        public DateTime ReleaseDate { get; set; }

        public int BandId { get; set; }
        public virtual Band Band { get; set; }
    }
}
