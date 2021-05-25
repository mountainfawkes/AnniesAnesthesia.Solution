using System.Collections.Generic;
using System;
using System.ComponentModel;//new line
using System.ComponentModel.DataAnnotations;//new line


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

    [DisplayName("RealBirthDate")]//new line
    [DataType(DataType.Date)]//new line
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]//new line
    public DateTime RealBirthDate { get; set; }

    public string Ailment { get; set; }
    public virtual ICollection<DoctorPatient> JoinEntities { get; }
  }
}