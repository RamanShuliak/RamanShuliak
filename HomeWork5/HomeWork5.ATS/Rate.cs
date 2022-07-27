using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5.ATS
{
    public class Rate
    {
        public string Name { get; set; }

        public int Cost { get; set; }

        public Rate(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}
