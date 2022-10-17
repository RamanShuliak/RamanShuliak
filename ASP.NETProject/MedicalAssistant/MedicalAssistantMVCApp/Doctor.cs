namespace MedicalAssistantMVCApp
{
    public class Doctor
    {
        public Guid Id { get; set; }
        public string Specialisation { get; set; }
        public Guid VisitId { get; set; }
        public virtual List<Visit> Visits { get; set; }
        public virtual DoctorPersonalData PersonalData { get; set; }

    }
}