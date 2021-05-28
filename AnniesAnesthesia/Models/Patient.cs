using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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

    [DisplayName("RealBirthDate")]
    [DataType(DataType.Date)]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
    public DateTime RealBirthDate { get; set; }

    public string Ailment { get; set; }
    public virtual ICollection<DoctorPatient> JoinEntities { get; }
    // public string Birthdate { get; set; }
  }
}