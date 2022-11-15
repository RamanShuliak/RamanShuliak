using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalAssistantMVCProject.DataBase.Entities;
using Microsoft.EntityFrameworkCore;

namespace MedicalAssistantMVCProject.DataBase
{
    public class MedicalAssistantDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<DrugDose> DrugsDoses { get; set; }
        public DbSet<DrugRegimen> DrugRegimens { get; set; }
        public DbSet<DrugCost> DrugCosts { get; set; }
        public DbSet<Research> Researches { get; set; }
        public DbSet<ResearchResult> ResearchResults { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorPersonalData> DoctorPersonalData { get; set; }
        public DbSet<Vaccine> Vaccines { get; set; }
        public DbSet<FirstMedicalAidProtocol> FirstMedicalAidProtocols { get; set; }

        public MedicalAssistantDbContext(DbContextOptions<MedicalAssistantDbContext> options)
            : base(options)
        {
        }
    }
}
