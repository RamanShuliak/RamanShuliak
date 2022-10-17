namespace MedicalAssistantMVCApp
{
    public class Drug
    {
        public Guid Id { get; set; }
        public string DrugName { get; set; }
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        public virtual List<DrugDose> DrugDoses { get; set; }
        public virtual List<DrugRegimen> DrugRegimens { get; set; }
        public virtual List<DrugCost> DrugCosts { get; set; }


    }
}
