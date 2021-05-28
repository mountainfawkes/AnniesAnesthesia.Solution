using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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

    [DisplayName("RealHireDate")]
    [DataType(DataType.Date)]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
    public DateTime RealHireDate { get; set; }

    public virtual ICollection<DoctorPatient> JoinEntities { get; set; }
    public virtual ICollection<DoctorSpecialty> JoinEntitiesSpecialty { get; set; }
  }
}