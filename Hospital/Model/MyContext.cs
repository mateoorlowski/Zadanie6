using Hospital.Configuration;
using Microsoft.AspNetCore.Connections;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Model;

public class MyContext : DbContext
{
    public MyContext()
    {
    }

    public MyContext(DbContextOptions<MyContext> options) : base(options)
    {
    }

    public virtual DbSet<Doctor> Doctors { get; set; }
    public virtual DbSet<Patient> Patients { get; set; }
    public virtual DbSet<Prescription> Prescriptions { get; set; }
    public virtual DbSet<Medicament> Medicaments { get; set; }
    public virtual DbSet<PrescriptionMedicament> PrescriptionMedicaments { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new DoctorConfiguration());
        modelBuilder.ApplyConfiguration(new PatientConfiguration());
        modelBuilder.ApplyConfiguration(new PrescriptionConfiguration());
        modelBuilder.ApplyConfiguration(new MedicamentConfiguration());
        modelBuilder.ApplyConfiguration(new PrescriptionMedicamentConfiguration());
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=master;User Id=sa;Password=zaq12wsx;TrustServerCertificate=true;");
        }
    }
}