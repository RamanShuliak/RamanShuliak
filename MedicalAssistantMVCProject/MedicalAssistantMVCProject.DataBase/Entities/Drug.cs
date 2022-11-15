using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAssistantMVCProject.DataBase.Entities
{
    public class Drug
    {
        public Guid Id { get; set; }
        public string DrugName { get; set; }

        public Guid UserId { get; set; }
        public virtual User User { get; set; }

        public virtual List<DrugDose> DrugDoses { get; set; }
        public virtual List<DrugRegimen> DrugRegimens { get; set; }
        public virtual List<DrugCost> DrugCosts { get; set; }
    }
}
