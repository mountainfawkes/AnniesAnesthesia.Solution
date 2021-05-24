using Microsoft.EntityFrameworkCore;

namespace AnniesAnesthesia.Models
{
  public class ClinicContext : DbContext
  {
    public virtual DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Specialty> Specialties { get; set; }
    public DbSet<DoctorPatient> DoctorPatient { get; set; }
<<<<<<< HEAD
    public DbSet<DoctorSpecialty> DoctorSpecialties { get; set; }
=======
>>>>>>> e450e1f (completes and implements CRUD functionality Co-authored-by: Ahmed Ghouzlane <ahmedghouzlane@gmail.com> Co-authored-by: Tiffany Greathead <tiffanygreathead@gmail.com> Co-authored-by: Giancarlo Vigneri <bobloblaw.vigneri@gmail.com>)
    public ClinicContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}