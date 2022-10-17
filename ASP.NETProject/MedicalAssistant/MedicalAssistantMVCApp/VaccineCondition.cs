namespace MedicalAssistantMVCApp
{
    public class VaccineCondition
    {
        public Guid Id { get; set; }
        public string ConditionName { get; set; }
        public Guid VaccineId { get; set; }
        public virtual Vaccine Vaccine { get; set; }
    }
}
