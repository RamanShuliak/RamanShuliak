using Microsoft.EntityFrameworkCore;
namespace MedicalAssistantMVCApp
{
    public class AssistantDbContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<DrugDose> DrugsDoses { get; set; }
        public DbSet<DrugRegimen> DrugRegimens { get; set; }
        public DbSet<DrugCost> DrugCosts { get; set; }
        public DbSet<Research> Researches { get; set; }
        public DbSet<ResearchResult> ResearchResults { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<VisitCondition> VisitConditions { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorPersonalData> DoctorPersonalData { get; set; }
        public DbSet<Vaccine> Vaccines { get; set; }
        public DbSet<VaccineCondition> VaccineConditions { get; set; }
        public DbSet<FirstMedicalAidProtocol> FirstMedicalAidProtocols { get; set; }
        public DbSet<HealthDiary> HealthDiaries { get; set; }

        private const string ConnectionString =
            "Server=HPPROBOOK;" +
            "Database=MedicalAssistantDbMain;" +
            "Trusted_Connection=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
