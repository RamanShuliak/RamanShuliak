using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAssistantMVCProject.DataBase.Entities
{
    public class ResearchResult
    {
        public Guid Id { get; set; }
        public DateTime ResearchDate { get; set; }
        public string ResearchResultLink { get; set; }

        public Guid ResearchId { get; set; }
        public virtual Research Research { get; set; }
    }
}
