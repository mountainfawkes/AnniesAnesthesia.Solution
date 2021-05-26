using System.Collections.Generic;
using System;
using System.ComponentModel;//new line
using System.ComponentModel.DataAnnotations;//new line

namespace AnniesAnesthesia.Models
{
  public class Doctor
  {
    
    public Doctor()
    {
      this.JoinEntities = new HashSet<DoctorPatient>();
      this.JoinEntitiesSpecialty = new HashSet<DoctorSpecialty>();
    }

    public int DoctorId { get; set; }
    public string Name { get; set; }

    [DisplayName("RealHireDate")]//new line
    [DataType(DataType.Date)]//new line
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]//new line
    public DateTime RealHireDate { get; set; }

    public virtual ICollection<DoctorPatient> JoinEntities { get; set; }
    public virtual ICollection<DoctorSpecialty> JoinEntitiesSpecialty { get; set; }
  }
}