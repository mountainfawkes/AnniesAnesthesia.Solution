using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using AnniesAnesthesia.Models;

namespace AnniesAnesthesia
{
  public class SpecialtiesController : Controller
  {
    private readonly ClinicContext _db;

    public SpecialtiesController(ClinicContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Specialties.ToList());
    }
    public ActionResult Create()
    {
      ViewBag.DoctorId = new SelectList(_db.Doctors, "DoctorId", "Name");
<<<<<<< HEAD
      ViewBag.SpecialtyId = new SelectList(_db.Specialties, "SpecialtyId", "SpecialtyName");
=======
>>>>>>> db9ab8b (refactors with a new Specialties model)
      return View();
    }
    [HttpPost]
    public ActionResult Create(Specialty specialty, int DoctorId)
    {
      _db.Specialties.Add(specialty);
      _db.SaveChanges();
      if (DoctorId != 0)
      {
        _db.DoctorSpecialties.Add(new DoctorSpecialty() { DoctorId = DoctorId, SpecialtyId = specialty.SpecialtyId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
<<<<<<< HEAD
    // public ActionResult Details(int id)
    // {
    //   var thisSpecialty = _db.Specialties
    //     .Include(specialty => specialty.JoinEntitiesSpecialty)
    //     .ThenInclude(join => join.Doctor)
    //     .FirstOrDefault(specialty => specialty.SpecialtyId == id);
    //   return View(thisSpecialty);
    // }
=======
    public ActionResult Details(int id)
    {
      var thisSpecialty = _db.Specialties
        .Include(specialty => specialty.JoinEntitiesSpecialty)
        .ThenInclude(join => join.Doctor)
        .FirstOrDefault(specialty => specialty.SpecialtyId == id);
      return View(thisSpecialty);
    }
>>>>>>> db9ab8b (refactors with a new Specialties model)
    public ActionResult Edit(int id)
    {
      var thisSpecialty = _db.Specialties.FirstOrDefault(specialty => specialty.SpecialtyId == id);
      ViewBag.DoctorId = new SelectList(_db.Doctors, "DoctorId", "Name");
      return View(thisSpecialty);
    }
    [HttpPost]
    public ActionResult Edit(Specialty specialty, int DoctorId)
    {
      if (DoctorId != 0)
      {
        _db.DoctorSpecialties.Add(new DoctorSpecialty() { DoctorId = DoctorId, SpecialtyId = specialty.SpecialtyId });
      }
      _db.Entry(specialty).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult AddDoctor(int id)
    {
      var thisSpecialty = _db.Specialties.FirstOrDefault(Specialty => Specialty.SpecialtyId == id);
      ViewBag.DoctorId = new SelectList(_db.Doctors, "DoctorId", "Name");
      return View(thisSpecialty);
    }
    [HttpPost]
    public ActionResult AddDoctor(Specialty specialty, int DoctorId)
    {
      if (DoctorId != 0)
      {
        _db.DoctorSpecialties.Add(new DoctorSpecialty() { DoctorId = DoctorId, SpecialtyId = specialty.SpecialtyId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Delete(int id)
    {
      var thisSpecialty = _db.Specialties.FirstOrDefault(specialty => specialty.SpecialtyId == id);
      return View(thisSpecialty);
    }
    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
       var thisSpecialty = _db.Specialties.FirstOrDefault(specialty => specialty.SpecialtyId == id);
      _db.Specialties.Remove(thisSpecialty);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    [HttpPost]
<<<<<<< HEAD
    public ActionResult DeleteDoctor(int joinId)// do we need this?
=======
    public ActionResult DeleteCategory(int joinId)
>>>>>>> db9ab8b (refactors with a new Specialties model)
    {
      var joinEntry = _db.DoctorSpecialties.FirstOrDefault(entry => entry.DoctorSpecialtyId == joinId);
      _db.DoctorSpecialties.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}