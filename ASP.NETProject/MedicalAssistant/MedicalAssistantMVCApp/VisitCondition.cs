namespace MedicalAssistantMVCApp
{
    public class VisitCondition
    {
        public Guid Id { get; set; }
        public string ConditionName { get; set; }
        public Guid VisitId { get; set; }
        public virtual Visit Visit { get; set; }
    }
}
