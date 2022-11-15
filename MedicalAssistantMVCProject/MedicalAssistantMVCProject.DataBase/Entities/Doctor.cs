using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAssistantMVCProject.DataBase.Entities
{
    public class Doctor
    {
        public Guid Id { get; set; }
        public string Specialisation { get; set; }

        public Guid VisitId { get; set; }
        public virtual List<Visit> Visits { get; set; }

        public virtual DoctorPersonalData PersonalData { get; set; }
    }
}
