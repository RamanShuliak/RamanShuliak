namespace MedicalAssistantMVCApp
{
    public class DrugCost
    {
        public Guid Id { get; set; }
        public decimal NumberOfCost { get; set; }
        public string TypeOfCurrency { get; set; }
        public Guid DrugId { get; set; }
        public virtual Drug Drug { get; set; }
    }
}
