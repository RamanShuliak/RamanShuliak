using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAssistantMVCProject.DataBase.Entities
{
    public class DrugRegimen
    {
        public Guid Id { get; set; }
        public int NumberOfDosePerTime { get; set; }
        public string TypeOfTime { get; set; }

        public Guid DrugId { get; set; }
        public virtual Drug Drug { get; set; }
    }
}
