namespace MedicalAssistantMVCApp
{
    public class DrugDose
    {
        public Guid Id { get; set; }
        public int DoseAmount { get; set; }
        public string DoseMeasure { get; set; }
        public Guid DrugId { get; set; }
        public virtual Drug Drug { get; set; }



    }
}
