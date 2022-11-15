using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAssistantMVCProject.DataBase.Entities
{
    public class Vaccine
    {
        public Guid Id { get; set; }
        public string DiseaseName { get; set; }
        public string VaccineType { get; set; }
        public bool IsGiven { get; set; }
        public DateTime VaccinationDate { get; set; }
        public DateTime RevactinationDate { get; set; }

        public Guid UserId { get; set; }
        public virtual User User { get; set; }
    }
}
