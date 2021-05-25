using System.Collections.Generic;
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> db9ab8b (refactors with a new Specialties model)
using System;
using System.ComponentModel;//new line
using System.ComponentModel.DataAnnotations;//new line

<<<<<<< HEAD
=======
>>>>>>> fbd9cde (adds CRUD functionality to doctor and patient models and routes Co-authored-by: Ahmed Ghouzlane <ahmedghouzlane@gmail.com> Co-authored-by: Tiffany Greathead <tiffanygreathead@gmail.com> Co-authored-by: Giancarlo Vigneri <bobloblaw.vigneri@gmail.com>)
=======
>>>>>>> db9ab8b (refactors with a new Specialties model)

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
<<<<<<< HEAD
=======
>>>>>>> db9ab8b (refactors with a new Specialties model)

    [DisplayName("RealBirthDate")]//new line
    [DataType(DataType.Date)]//new line
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]//new line
    public DateTime RealBirthDate { get; set; }

<<<<<<< HEAD
    public string Ailment { get; set; }
    public virtual ICollection<DoctorPatient> JoinEntities { get; }
=======
    public string Birthdate { get; set; }
=======
>>>>>>> db9ab8b (refactors with a new Specialties model)
    public string Ailment { get; set; }
<<<<<<< HEAD
>>>>>>> fbd9cde (adds CRUD functionality to doctor and patient models and routes Co-authored-by: Ahmed Ghouzlane <ahmedghouzlane@gmail.com> Co-authored-by: Tiffany Greathead <tiffanygreathead@gmail.com> Co-authored-by: Giancarlo Vigneri <bobloblaw.vigneri@gmail.com>)
=======
    public virtual ICollection<DoctorPatient> JoinEntities { get; }
>>>>>>> e450e1f (completes and implements CRUD functionality Co-authored-by: Ahmed Ghouzlane <ahmedghouzlane@gmail.com> Co-authored-by: Tiffany Greathead <tiffanygreathead@gmail.com> Co-authored-by: Giancarlo Vigneri <bobloblaw.vigneri@gmail.com>)
  }
}