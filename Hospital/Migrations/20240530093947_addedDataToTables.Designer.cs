﻿// <auto-generated />
using System;
using Hospital.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hospital.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20240530093947_addedDataToTables")]
    partial class addedDataToTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.4.24267.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Hospital.Model.Doctor", b =>
                {
                    b.Property<int>("IdDoctor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDoctor"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdDoctor")
                        .HasName("Doctor_PK");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            IdDoctor = 1,
                            Email = "SampleDoctor@gmail.com",
                            FirstName = "Sample",
                            LastName = "Doctor"
                        },
                        new
                        {
                            IdDoctor = 2,
                            Email = "JakubBiologist@gmail.com",
                            FirstName = "Jakub",
                            LastName = "Biologist"
                        },
                        new
                        {
                            IdDoctor = 3,
                            Email = "MichalPediatrician@gmail.com",
                            FirstName = "Michal",
                            LastName = "Pediatrician"
                        },
                        new
                        {
                            IdDoctor = 4,
                            Email = "SergioPsychiatrist@gmail.com",
                            FirstName = "Sergio",
                            LastName = "Psychiatrist"
                        },
                        new
                        {
                            IdDoctor = 5,
                            Email = "PabloAnesthesiologist@gmail.com",
                            FirstName = "Pablo",
                            LastName = "Anesthesiologist"
                        },
                        new
                        {
                            IdDoctor = 6,
                            Email = "AzucarDiabetes@gmail.com",
                            FirstName = "Azucar",
                            LastName = "Diabetes"
                        });
                });

            modelBuilder.Entity("Hospital.Model.Medicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMedicament"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdMedicament")
                        .HasName("IdMedicament_PK");

                    b.ToTable("Medicaments");

                    b.HasData(
                        new
                        {
                            IdMedicament = 1,
                            Description = "Painkiller, 200mg 3 times a day.",
                            Name = "Ibuprofène",
                            Type = "Anti inflamatory pills"
                        },
                        new
                        {
                            IdMedicament = 2,
                            Description = "From 10 to 1000 times a day.",
                            Name = "Happyness",
                            Type = "Anti sadness pills"
                        },
                        new
                        {
                            IdMedicament = 3,
                            Description = "CAN HARM YOUR HEALTH.",
                            Name = "Sadness",
                            Type = "Anti happyness pills"
                        });
                });

            modelBuilder.Entity("Hospital.Model.Patient", b =>
                {
                    b.Property<int>("IdPatient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPatient"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdPatient")
                        .HasName("IdPatient_PK");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            IdPatient = 1,
                            BirthDate = new DateTime(1999, 5, 30, 11, 39, 47, 147, DateTimeKind.Local).AddTicks(586),
                            FirstName = "Jakub",
                            LastName = "Nowak"
                        },
                        new
                        {
                            IdPatient = 2,
                            BirthDate = new DateTime(2003, 5, 30, 11, 39, 47, 147, DateTimeKind.Local).AddTicks(641),
                            FirstName = "Michal",
                            LastName = "Kowalski"
                        },
                        new
                        {
                            IdPatient = 3,
                            BirthDate = new DateTime(1997, 5, 30, 11, 39, 47, 147, DateTimeKind.Local).AddTicks(644),
                            FirstName = "Patient",
                            LastName = "Patientowich"
                        },
                        new
                        {
                            IdPatient = 4,
                            BirthDate = new DateTime(2002, 5, 30, 11, 39, 47, 147, DateTimeKind.Local).AddTicks(647),
                            FirstName = "Sergio",
                            LastName = "Kotowich"
                        },
                        new
                        {
                            IdPatient = 5,
                            BirthDate = new DateTime(1974, 5, 30, 11, 39, 47, 147, DateTimeKind.Local).AddTicks(649),
                            FirstName = "Ala",
                            LastName = "Peronska"
                        },
                        new
                        {
                            IdPatient = 6,
                            BirthDate = new DateTime(1995, 5, 30, 11, 39, 47, 147, DateTimeKind.Local).AddTicks(652),
                            FirstName = "Kot",
                            LastName = "Zygmund"
                        },
                        new
                        {
                            IdPatient = 7,
                            BirthDate = new DateTime(1970, 5, 30, 11, 39, 47, 147, DateTimeKind.Local).AddTicks(654),
                            FirstName = "Natiel",
                            LastName = "Patient"
                        },
                        new
                        {
                            IdPatient = 8,
                            BirthDate = new DateTime(1957, 5, 30, 11, 39, 47, 147, DateTimeKind.Local).AddTicks(656),
                            FirstName = "Jas",
                            LastName = "Profase"
                        });
                });

            modelBuilder.Entity("Hospital.Model.Prescription", b =>
                {
                    b.Property<int>("IdPrescription")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPrescription"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdDoctor")
                        .HasColumnType("int");

                    b.Property<int>("IdPatient")
                        .HasColumnType("int");

                    b.HasKey("IdPrescription")
                        .HasName("Prescription_PK");

                    b.HasIndex("IdDoctor");

                    b.HasIndex("IdPatient");

                    b.ToTable("Prescriptions");

                    b.HasData(
                        new
                        {
                            IdPrescription = 1,
                            Date = new DateTime(2024, 5, 30, 11, 39, 47, 147, DateTimeKind.Local).AddTicks(7793),
                            DueDate = new DateTime(2024, 6, 29, 11, 39, 47, 147, DateTimeKind.Local).AddTicks(7812),
                            IdDoctor = 1,
                            IdPatient = 1
                        },
                        new
                        {
                            IdPrescription = 2,
                            Date = new DateTime(2024, 5, 30, 11, 39, 47, 147, DateTimeKind.Local).AddTicks(7817),
                            DueDate = new DateTime(2024, 6, 29, 11, 39, 47, 147, DateTimeKind.Local).AddTicks(7818),
                            IdDoctor = 2,
                            IdPatient = 2
                        },
                        new
                        {
                            IdPrescription = 3,
                            Date = new DateTime(2024, 5, 30, 11, 39, 47, 147, DateTimeKind.Local).AddTicks(7821),
                            DueDate = new DateTime(2024, 6, 29, 11, 39, 47, 147, DateTimeKind.Local).AddTicks(7822),
                            IdDoctor = 3,
                            IdPatient = 3
                        });
                });

            modelBuilder.Entity("Hospital.Model.PrescriptionMedicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .HasColumnType("int");

                    b.Property<int>("IdPrescription")
                        .HasColumnType("int");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("Dose")
                        .HasColumnType("int");

                    b.HasKey("IdMedicament", "IdPrescription")
                        .HasName("PrescriptionMedicamend_PK");

                    b.HasIndex("IdPrescription");

                    b.ToTable("Prescription_Medicament", (string)null);

                    b.HasData(
                        new
                        {
                            IdMedicament = 1,
                            IdPrescription = 1,
                            Details = "2 pills in am and pm",
                            Dose = 200
                        },
                        new
                        {
                            IdMedicament = 2,
                            IdPrescription = 1,
                            Details = "2 pills in am and pm",
                            Dose = 250
                        },
                        new
                        {
                            IdMedicament = 2,
                            IdPrescription = 2,
                            Details = "2 pills in am and pm",
                            Dose = 250
                        },
                        new
                        {
                            IdMedicament = 3,
                            IdPrescription = 3,
                            Details = "2 pills in am and pm",
                            Dose = 250
                        });
                });

            modelBuilder.Entity("Hospital.Model.Prescription", b =>
                {
                    b.HasOne("Hospital.Model.Doctor", "IdDoctorNav")
                        .WithMany("Prescriptions")
                        .HasForeignKey("IdDoctor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("Doctor_Prescription_FK");

                    b.HasOne("Hospital.Model.Patient", "IdPatientNav")
                        .WithMany("Prescriptions")
                        .HasForeignKey("IdPatient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("Patient_Prescription_FK");

                    b.Navigation("IdDoctorNav");

                    b.Navigation("IdPatientNav");
                });

            modelBuilder.Entity("Hospital.Model.PrescriptionMedicament", b =>
                {
                    b.HasOne("Hospital.Model.Medicament", "IdMedicamentNav")
                        .WithMany("PrescriptionMedicaments")
                        .HasForeignKey("IdMedicament")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("Medicament_PrescriptionMedicament_FK");

                    b.HasOne("Hospital.Model.Prescription", "IdPrescriptionNav")
                        .WithMany("PrescriptionMedicaments")
                        .HasForeignKey("IdPrescription")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("Prescription_PrescriptionMedicament_FK");

                    b.Navigation("IdMedicamentNav");

                    b.Navigation("IdPrescriptionNav");
                });

            modelBuilder.Entity("Hospital.Model.Doctor", b =>
                {
                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("Hospital.Model.Medicament", b =>
                {
                    b.Navigation("PrescriptionMedicaments");
                });

            modelBuilder.Entity("Hospital.Model.Patient", b =>
                {
                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("Hospital.Model.Prescription", b =>
                {
                    b.Navigation("PrescriptionMedicaments");
                });
#pragma warning restore 612, 618
        }
    }
}
