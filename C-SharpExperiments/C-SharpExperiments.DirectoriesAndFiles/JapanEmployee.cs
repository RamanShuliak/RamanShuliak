using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpExperiments.DirectoriesAndFiles
{
    public class JapanEmployee
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public string Company { get; set; }

        public JapanEmployee()
        {
        }
        public JapanEmployee(string name, int duration, string company)
        {
            Name = name;
            Duration = duration;
            Company = company;
        }
    }
}
