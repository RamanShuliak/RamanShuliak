﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.Exprtiments.EF
{
    public class Band
    {
        public int Id { get; set; }
        public string BandName { get; set; }
        public string Label { get; set; }

        public virtual List<Song> Songs { get; set; }

    }
}
