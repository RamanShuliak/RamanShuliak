namespace MedicalAssistantMVCApp
{
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public virtual List<Drug> Drugs { get; set; }
        public virtual List<Research> Researches { get; set; }
        public virtual List<Visit> Visits { get; set; }
        public virtual List<Vaccine> Vaccines { get; set; }
        public virtual List<FirstMedicalAidProtocol> FirstMedicalAidProtocols { get; set; }
        public virtual List<HealthDiary> HealthDiaries { get; set; }
    }
}
