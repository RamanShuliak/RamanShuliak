using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAssistantMVCProject.DataBase.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        public virtual List<Drug> Drugs { get; set; }
        public virtual List<Research> Researches { get; set; }
        public virtual List<Visit> Visits { get; set; }
        public virtual List<Vaccine> Vaccines { get; set; }
        public virtual List<FirstMedicalAidProtocol> FirstMedicalAidProtocols { get; set; }
    }
}
