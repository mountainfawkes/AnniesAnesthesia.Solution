using System.Collections.Generic;
<<<<<<< HEAD
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
=======

namespace AnniesAnesthesia
{
  public class Doctor
  {
    public Doctor()
    {
      this.JoinEntities = new HashSet<DoctorPatient>();
>>>>>>> fbd9cde (adds CRUD functionality to doctor and patient models and routes Co-authored-by: Ahmed Ghouzlane <ahmedghouzlane@gmail.com> Co-authored-by: Tiffany Greathead <tiffanygreathead@gmail.com> Co-authored-by: Giancarlo Vigneri <bobloblaw.vigneri@gmail.com>)
    }

    public int DoctorId { get; set; }
    public string Name { get; set; }
<<<<<<< HEAD
    //public string Specialty { get; set; }//get rid of this

    [DisplayName("RealHireDate")]//new line
    [DataType(DataType.Date)]//new line
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]//new line
    public DateTime RealHireDate { get; set; }
    public virtual ICollection<DoctorPatient> JoinEntities { get; set; }
    public virtual ICollection<DoctorSpecialty> JoinEntitiesSpecialty { get; set; }
=======
    public string Specialty { get; set; }
    public string HireDate { get; set; }
>>>>>>> fbd9cde (adds CRUD functionality to doctor and patient models and routes Co-authored-by: Ahmed Ghouzlane <ahmedghouzlane@gmail.com> Co-authored-by: Tiffany Greathead <tiffanygreathead@gmail.com> Co-authored-by: Giancarlo Vigneri <bobloblaw.vigneri@gmail.com>)
  }
}