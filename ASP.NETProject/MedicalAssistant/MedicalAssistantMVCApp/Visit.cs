namespace MedicalAssistantMVCApp
{
    public class Visit
    {
        public Guid Id { get; set; }
        public DateTime VisitTime { get; set; }
        public string VisitAdress { get; set; }
        public string VisitResultLink { get; set; }
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        public virtual VisitCondition VisitCondition { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
