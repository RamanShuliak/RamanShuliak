using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAssistantMVCProject.DataBase.Entities
{
    public class DoctorPersonalData
    {
        public Guid Id { get; set; }
        public string DoctorName { get; set; }
        public string DoctorSurname { get; set; }
        public string DoctorPhoneNumber { get; set; }

        public Guid DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
