using System.Collections.Generic;

namespace AnniesAnesthesia.Models
{
  public class Patient
  {
    public Patient()
    {
      this.JoinEntities = new HashSet<DoctorPatient>();
    }
    public int PatientId { get; set; }
    public string Name { get; set; }
    public string Birthdate { get; set; }
    public string Ailment { get; set; }
  }
}