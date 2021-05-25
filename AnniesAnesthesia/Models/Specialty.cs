using System.Collections.Generic;
using System;


namespace AnniesAnesthesia.Models
{
  public class Specialty
  {
    public Specialty()
    {
      this.JoinEntitiesSpecialty = new HashSet<DoctorSpecialty>();
    }

    public int SpecialtyId { get; set; }
    public string SpecialtyName { get; set;}
    public virtual ICollection<DoctorSpecialty> JoinEntitiesSpecialty { get; set;}
  }
}