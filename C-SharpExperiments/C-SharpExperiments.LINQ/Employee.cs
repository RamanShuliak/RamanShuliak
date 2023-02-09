using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpExperiments.LINQ
{
    public class Employee: Person
    {
        public string Company { get; set; }

        public Employee() { }

        public Employee(string name, int age, string company)
        {
            Name = name;
            Age = age;
            Company = company;
        }
    }
}
