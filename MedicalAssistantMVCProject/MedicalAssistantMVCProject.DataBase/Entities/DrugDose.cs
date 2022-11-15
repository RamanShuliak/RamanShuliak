using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAssistantMVCProject.DataBase.Entities
{
    public class DrugDose
    {
        public Guid Id { get; set; }
        public int DoseAmount { get; set; }
        public string DoseMeasure { get; set; }

        public Guid DrugId { get; set; }
        public virtual Drug Drug { get; set; }
    }
}
