using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAssistantMVCProject.DataBase.Entities
{
    public class DrugCost
    {
        public Guid Id { get; set; }
        public decimal NumberOfCost { get; set; }
        public string TypeOfCurrency { get; set; }

        public Guid DrugId { get; set; }
        public virtual Drug Drug { get; set; }
    }
}
