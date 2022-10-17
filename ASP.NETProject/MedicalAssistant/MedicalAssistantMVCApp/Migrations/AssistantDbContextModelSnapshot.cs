﻿// <auto-generated />
using System;
using MedicalAssistantMVCApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MedicalAssistantMVCApp.Migrations
{
    [DbContext(typeof(AssistantDbContext))]
    partial class AssistantDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MedicalAssistantMVCApp.Doctor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Specialisation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("VisitId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("MedicalAssistantMVCApp.DoctorPersonalData", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DoctorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DoctorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId")
                        .IsUnique();

                    b.ToTable("DoctorPersonalData");
                });

            modelBuilder.Entity("MedicalAssistantMVCApp.Drug", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DrugName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Drugs");
                });

            modelBuilder.Entity("MedicalAssistantMVCApp.DrugCost", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DrugId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("NumberOfCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TypeOfCurrency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DrugId");

                    b.ToTable("DrugCosts");
                });

            modelBuilder.Entity("MedicalAssistantMVCApp.DrugDose", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DoseAmount")
                        .HasColumnType("int");

                    b.Property<string>("DoseMeasure")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("DrugId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DrugId");

                    b.ToTable("DrugsDoses");
                });

            modelBuilder.Entity("MedicalAssistantMVCApp.DrugRegimen", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DrugId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("NumberOfDosePerTyme")
                        .HasColumnType("int");

                    b.Property<string>("TypeOfTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DrugId");

                    b.ToTable("DrugRegimens");
                });

            modelBuilder.Entity("MedicalAssistantMVCApp.FirstMedicalAidProtocol", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProblemTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProtocolLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("FirstMedicalAidProtocols");
                });

            modelBuilder.Entity("MedicalAssistantMVCApp.HealthDiary", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("HealthIndicatorAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("HealthIndicatorMeasure")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("HealthIndicatorNormalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("HealthIndicatorType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("HealthDiaries");
                });

            modelBuilder.Entity("MedicalAssistantMVCApp.Research", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NormalResultLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResearchName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Researches");
                });

            modelBuilder.Entity("MedicalAssistantMVCApp.ResearchResult", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ResearchDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ResearchId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ResearchResultLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ResearchId");

                    b.ToTable("ResearchResults");
                });

            modelBuilder.Entity("MedicalAssistantMVCApp.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MedicalAssistantMVCApp.Vaccine", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiseaseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RevactinationDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("VaccinationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("VaccineType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Vaccines");
                });

            modelBuilder.Entity("MedicalAssistantMVCApp.VaccineCondition", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConditionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("VaccineId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("VaccineId")
                        .IsUnique();

                    b.ToTable("VaccineConditions");
                });

            modelBuilder.Entity("MedicalAssistantMVCApp.Visit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DoctorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("VisitAdress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VisitResultLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("VisitTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("UserId");

                    b.ToTable("Visits");
                });

            modelBuilder.Entity("MedicalAssistantMVCApp.VisitCondition", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConditionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("VisitId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("VisitId")
                        .IsUnique();

                    b.ToTable("VisitConditions");
                });

            modelBuilder.Entity("MedicalAssistantMVCApp.DoctorPersonalData", b =>
                {
                    b.HasOne("MedicalAssistantMVCApp.Doctor", "Doctor")
                        .WithOne("PersonalData")
                        .HasForeignKey("MedicalAssistantMVCApp.DoctorPersonalData", "DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("MedicalAssistantMVCApp.Drug", b =>
                {
                    b.HasOne("MedicalAssistantMVCApp.User", "User")
                        .WithMany("Drugs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MedicalAssistantMVCApp.DrugCost", b =>
                {
                    b.HasOne("MedicalAssistantMVCApp.Drug", "Drug")
                        .WithMany("DrugCosts")
                        .HasForeignKey("DrugId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Drug");
                });

            modelBuilder.Entity("MedicalAssistantMVCApp.DrugDose", b =>
                {
                    b.HasOne("MedicalAssistantMVCApp.Drug", "Drug")
                        .WithMany("DrugDoses")
                        .HasForeignKey("DrugId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Drug");
                });

            modelBuilder.Entity("MedicalAssistantMVCApp.DrugRegimen", b =>
                {
                    b.HasOne("MedicalAssistantMVCApp.Drug", "Drug")
                        .WithMany("DrugRegimens")
                        .HasForeignKey("DrugId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Drug");
                });

            modelBuilder.Entity("MedicalAssistantMVCApp.FirstMedicalAidProtocol", b =>
                {
                    b.HasOne("MedicalAssistantMVCApp.User", "User")
                        .WithMany("FirstMedicalAidProtocols")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MedicalAssistantMVCApp.HealthDiary", b =>
                {
                    b.HasOne("MedicalAssistantMVCApp.User", "User")
                        .WithMany("HealthDiaries")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MedicalAssistantMVCApp.Research", b =>
                {
                    b.HasOne("MedicalAssistantMVCApp.User", "User")
                        .WithMany("Researches")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MedicalAssistantMVCApp.ResearchResult", b =>
                {
                    b.HasOne("MedicalAssistantMVCApp.Research", "Research")
                        .WithMany("ResearchResults")
                        .HasForeignKey("ResearchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Research");
                });

            modelBuilder.Entity("MedicalAssistantMVCApp.Vaccine", b =>
                {
                    b.HasOne("MedicalAssistantMVCApp.User", "User")
                        .WithMany("Vaccines")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MedicalAssistantMVCApp.VaccineCondition", b =>
                {
                    b.HasOne("MedicalAssistantMVCApp.Vaccine", "Vaccine")
                        .WithOne("VaccineCondition")
                        .HasForeignKey("MedicalAssistantMVCApp.VaccineCondition", "VaccineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vaccine");
                });

            modelBuilder.Entity("MedicalAssistantMVCApp.Visit", b =>
                {
                    b.HasOne("MedicalAssistantMVCApp.Doctor", "Doctor")
                        .WithMany("Visits")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MedicalAssistantMVCApp.User", "User")
                        .WithMany("Visits")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MedicalAssistantMVCApp.VisitCondition", b =>
                {
                    b.HasOne("MedicalAssistantMVCApp.Visit", "Visit")
                        .WithOne("VisitCondition")
                        .HasForeignKey("MedicalAssistantMVCApp.VisitCondition", "VisitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Visit");
                });

            modelBuilder.Entity("MedicalAssistantMVCApp.Doctor", b =>
                {
                    b.Navigation("PersonalData")
                        .IsRequired();

                    b.Navigation("Visits");
                });

            modelBuilder.Entity("MedicalAssistantMVCApp.Drug", b =>
                {
                    b.Navigation("DrugCosts");

                    b.Navigation("DrugDoses");

                    b.Navigation("DrugRegimens");
                });

            modelBuilder.Entity("MedicalAssistantMVCApp.Research", b =>
                {
                    b.Navigation("ResearchResults");
                });

            modelBuilder.Entity("MedicalAssistantMVCApp.User", b =>
                {
                    b.Navigation("Drugs");

                    b.Navigation("FirstMedicalAidProtocols");

                    b.Navigation("HealthDiaries");

                    b.Navigation("Researches");

                    b.Navigation("Vaccines");

                    b.Navigation("Visits");
                });

            modelBuilder.Entity("MedicalAssistantMVCApp.Vaccine", b =>
                {
                    b.Navigation("VaccineCondition")
                        .IsRequired();
                });

            modelBuilder.Entity("MedicalAssistantMVCApp.Visit", b =>
                {
                    b.Navigation("VisitCondition")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
