using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAssistantMVCProject.DataBase.Entities
{
    public class FirstMedicalAidProtocol
    {
        public Guid Id { get; set; }
        public string ProblemTypeName { get; set; }
        public string ProtocolLink { get; set; }

        public Guid UserId { get; set; }
        public virtual User User { get; set; }
    }
}
