namespace MedicalAssistantMVCApp
{
    public class HealthDiary
    {
        public Guid Id { get; set; }
        public string HealthIndicatorType { get; set; }
        public decimal HealthIndicatorAmount { get; set; }
        public string HealthIndicatorMeasure { get; set; }
        public decimal HealthIndicatorNormalAmount { get; set; }
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
    }
}
