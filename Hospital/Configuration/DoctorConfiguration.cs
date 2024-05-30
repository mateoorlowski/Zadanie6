﻿using Hospital.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hospital.Configuration;

public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
{
    public void Configure(EntityTypeBuilder<Doctor> builder)
    {
        builder.HasKey(e => e.IdDoctor)
            .HasName("Doctor_PK");

        builder.Property(e => e.IdDoctor)
            .UseIdentityColumn();

        builder.Property(e => e.FirstName)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(e => e.LastName)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(e => e.Email)
            .HasMaxLength(100)
            .IsRequired();

        builder.HasIndex(e => e.Email)
            .IsUnique();
        
        var doctors = new List<Doctor>
        {
            new()
            {
                IdDoctor = 1,
                FirstName = "Sample",
                LastName = "Doctor",
                Email = "SampleDoctor@gmail.com"
            },
            new()
            {
                IdDoctor = 2,
                FirstName = "Jakub",
                LastName = "Biologist",
                Email = "JakubBiologist@gmail.com"
            },
            new()
            {
                IdDoctor = 3,
                FirstName = "Michal",
                LastName = "Pediatrician",
                Email = "MichalPediatrician@gmail.com"
            },
            new()
            {
                IdDoctor = 4,
                FirstName = "Sergio",
                LastName = "Psychiatrist",
                Email = "SergioPsychiatrist@gmail.com"
            },
            new()
            {
                IdDoctor = 5,
                FirstName = "Pablo",
                LastName = "Anesthesiologist",
                Email = "PabloAnesthesiologist@gmail.com"
            },
            new()
            {
                IdDoctor = 6,
                FirstName = "Azucar",
                LastName = "Diabetes",
                Email = "AzucarDiabetes@gmail.com"
            }
        };

        builder.HasData(doctors);
    }
}