namespace MedicalAssistantMVCApp
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
