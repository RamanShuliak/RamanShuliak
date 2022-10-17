namespace MedicalAssistantMVCApp
{
    public class DoctorPersonalData
    {
        public Guid Id { get; set; }
        public string DoctorName { get; set; }
        public string DoctorSurname { get; set; }
        public string DoctorPhoneNumber { get; set; }
        public Guid DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
