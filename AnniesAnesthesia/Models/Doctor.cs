using System.Collections.Generic;

namespace AnniesAnesthesia.Models
{
  public class Doctor
  {
    public Doctor()
    {
      this.JoinEntities = new HashSet<DoctorPatient>();
    }

    public int DoctorId { get; set; }
    public string Name { get; set; }
    public string Specialty { get; set; }
    public string HireDate { get; set; }
    public virtual ICollection<DoctorPatient> JoinEntities { get; set; }
  }
}