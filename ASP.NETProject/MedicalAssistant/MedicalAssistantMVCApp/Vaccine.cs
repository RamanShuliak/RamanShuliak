namespace MedicalAssistantMVCApp
{
    public class Vaccine
    {
        public Guid Id { get; set; }
        public string DiseaseName { get; set; }
        public string VaccineType { get; set; }
        public DateTime VaccinationDate { get; set; }
        public DateTime RevactinationDate { get; set; }
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        public virtual VaccineCondition VaccineCondition { get; set; }
    }
}
