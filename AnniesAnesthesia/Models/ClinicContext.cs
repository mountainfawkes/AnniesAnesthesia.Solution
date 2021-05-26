using Microsoft.EntityFrameworkCore;

namespace AnniesAnesthesia.Models
{
  public class ClinicContext : DbContext
  {
    public virtual DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Specialty> Specialties { get; set; }
    public DbSet<DoctorPatient> DoctorPatient { get; set; }
    public DbSet<DoctorSpecialty> DoctorSpecialties { get; set; }
    public ClinicContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}