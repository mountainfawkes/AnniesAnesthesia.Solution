<<<<<<< HEAD
using Microsoft.AspNetCore.Mvc.Rendering;
=======
>>>>>>> fbd9cde (adds CRUD functionality to doctor and patient models and routes Co-authored-by: Ahmed Ghouzlane <ahmedghouzlane@gmail.com> Co-authored-by: Tiffany Greathead <tiffanygreathead@gmail.com> Co-authored-by: Giancarlo Vigneri <bobloblaw.vigneri@gmail.com>)
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnniesAnesthesia.Models;
using System.Collections.Generic;
using System.Linq;

namespace AnniesAnesthesia.Controllers
{
  public class DoctorsController : Controller
  {
    private readonly ClinicContext _db;
    public DoctorsController(ClinicContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Doctor> model = _db.Doctors.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
<<<<<<< HEAD
      ViewBag.SpecialtyId = new SelectList(_db.Specialties, "SpecialtyId", "SpecialtyName");
=======
>>>>>>> fbd9cde (adds CRUD functionality to doctor and patient models and routes Co-authored-by: Ahmed Ghouzlane <ahmedghouzlane@gmail.com> Co-authored-by: Tiffany Greathead <tiffanygreathead@gmail.com> Co-authored-by: Giancarlo Vigneri <bobloblaw.vigneri@gmail.com>)
      return View();
    }

    [HttpPost]
    public ActionResult Create(Doctor doctor)
    {
      _db.Doctors.Add(doctor);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisDoctor = _db.Doctors
        .Include(doctor => doctor.JoinEntities)
        .ThenInclude(join => join.Patient)
        .FirstOrDefault(doctor => doctor.DoctorId == id);
      return View(thisDoctor);
    }

    public ActionResult Edit(int id)
    {
      var thisDoctor = _db.Doctors.FirstOrDefault(doctor => doctor.DoctorId == id);
<<<<<<< HEAD
      ViewBag.SpecialtyId = new SelectList(_db.Specialties, "SpecialtyId", "Name");
=======
>>>>>>> fbd9cde (adds CRUD functionality to doctor and patient models and routes Co-authored-by: Ahmed Ghouzlane <ahmedghouzlane@gmail.com> Co-authored-by: Tiffany Greathead <tiffanygreathead@gmail.com> Co-authored-by: Giancarlo Vigneri <bobloblaw.vigneri@gmail.com>)
      return View(thisDoctor);
    }

    [HttpPost]
<<<<<<< HEAD
    public ActionResult Edit(Doctor doctor, int specialtyId)//added int SpecialtyId
    {
      if (specialtyId != 0 )//new w/ added parameter
      {
        _db.DoctorSpecialties.Add(new DoctorSpecialty() { SpecialtyId = specialtyId, DoctorId = doctor.DoctorId});
      }//end new stuff
=======
    public ActionResult Edit(Doctor doctor)
    {
>>>>>>> fbd9cde (adds CRUD functionality to doctor and patient models and routes Co-authored-by: Ahmed Ghouzlane <ahmedghouzlane@gmail.com> Co-authored-by: Tiffany Greathead <tiffanygreathead@gmail.com> Co-authored-by: Giancarlo Vigneri <bobloblaw.vigneri@gmail.com>)
      _db.Entry(doctor).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisDoctor = _db.Doctors.FirstOrDefault(doctor => doctor.DoctorId == id);
      return View(thisDoctor);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisDoctor = _db.Doctors.FirstOrDefault(doctor => doctor.DoctorId == id);
      _db.Doctors.Remove(thisDoctor);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}