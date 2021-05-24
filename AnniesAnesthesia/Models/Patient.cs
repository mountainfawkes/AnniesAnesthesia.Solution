using System.Collections.Generic;
<<<<<<< HEAD
using System;
using System.ComponentModel;//new line
using System.ComponentModel.DataAnnotations;//new line

=======
>>>>>>> fbd9cde (adds CRUD functionality to doctor and patient models and routes Co-authored-by: Ahmed Ghouzlane <ahmedghouzlane@gmail.com> Co-authored-by: Tiffany Greathead <tiffanygreathead@gmail.com> Co-authored-by: Giancarlo Vigneri <bobloblaw.vigneri@gmail.com>)

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
<<<<<<< HEAD

    [DisplayName("RealBirthDate")]//new line
    [DataType(DataType.Date)]//new line
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]//new line
    public DateTime RealBirthDate { get; set; }

    public string Ailment { get; set; }
    public virtual ICollection<DoctorPatient> JoinEntities { get; }
=======
    public string Birthdate { get; set; }
    public string Ailment { get; set; }
>>>>>>> fbd9cde (adds CRUD functionality to doctor and patient models and routes Co-authored-by: Ahmed Ghouzlane <ahmedghouzlane@gmail.com> Co-authored-by: Tiffany Greathead <tiffanygreathead@gmail.com> Co-authored-by: Giancarlo Vigneri <bobloblaw.vigneri@gmail.com>)
  }
}