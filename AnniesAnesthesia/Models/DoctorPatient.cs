namespace AnniesAnesthesia.Models
{
  public class DoctorPatient
  {
    public int DoctorPatientId { get; set; }
    public int PatientId { get; set; }
    public int DoctorId { get; set; }
    public virtual Doctor Doctor { get; set; }
    public virtual Patient Patient { get; set; }
  }
}