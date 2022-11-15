using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAssistantMVCProject.DataBase.Entities
{
    public class Research
    {
        public Guid Id { get; set; }
        public string ResearchName { get; set; }
        public string NormalResultLink { get; set; }

        public Guid UserId { get; set; }
        public virtual User User { get; set; }

        public virtual List<ResearchResult> ResearchResults { get; set; }
    }
}
