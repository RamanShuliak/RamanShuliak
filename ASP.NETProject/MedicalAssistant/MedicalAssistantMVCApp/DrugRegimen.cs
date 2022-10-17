namespace MedicalAssistantMVCApp
{
    public class DrugRegimen
    {
        public Guid Id { get; set; }
        public int NumberOfDosePerTyme { get; set; }
        public string TypeOfTime { get; set; }
        public Guid DrugId { get; set; }
        public virtual Drug Drug { get; set; }


    }
}
