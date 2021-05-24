namespace AnniesAnesthesia.Models
{
  public class DoctorPatient
  {
    public int DoctorPatientId { get; set; }
    public int PatientId { get; set; }
    public int DoctorId { get; set; }
<<<<<<< HEAD
<<<<<<< HEAD
    public virtual Doctor Doctor { get; set; }
    public virtual Patient Patient { get; set; }
=======
    public Doctor Doctor { get; set; }
    public Patient Patient { get; set; }
>>>>>>> e450e1f (completes and implements CRUD functionality Co-authored-by: Ahmed Ghouzlane <ahmedghouzlane@gmail.com> Co-authored-by: Tiffany Greathead <tiffanygreathead@gmail.com> Co-authored-by: Giancarlo Vigneri <bobloblaw.vigneri@gmail.com>)
=======
    public virtual Doctor Doctor { get; set; }
    public virtual Patient Patient { get; set; }
>>>>>>> 54910cc (creates Home and Patients views)
  }
}