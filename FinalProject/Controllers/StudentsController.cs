using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    public class StudentsController : Controller
    {
        private VeteransDBEntities db = new VeteransDBEntities();

        // GET: Students
        public ActionResult Index()
        {
            var students = db.Students.Include(s => s.DegreeTitle).Include(s => s.DegreeType1).Include(s => s.VaChapter1);
            return View(students.ToList());
        }

        // GET: Students/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // GET: Students/Create
        public ActionResult Create()
        {
            ViewBag.Degree = new SelectList(db.DegreeTitles, "DegreeId", "DegreeName");
            ViewBag.DegreeType = new SelectList(db.DegreeTypes, "TypeId", "DegreeType1");
            ViewBag.VaChapter = new SelectList(db.VaChapters, "ChapterId", "ChapterName");
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StudentId,QuarterStart,StudentNumber,FirstName,MiddleName,LastName,Gender,DOB,DegreeType,Degree,VaChapter,Adress,City,State,ZipCode,PhoneNumber,AltPhone,Email,AltEmail")] Student student)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Degree = new SelectList(db.DegreeTitles, "DegreeId", "DegreeName", student.Degree);
            ViewBag.DegreeType = new SelectList(db.DegreeTypes, "TypeId", "DegreeType1", student.DegreeType);
            ViewBag.VaChapter = new SelectList(db.VaChapters, "ChapterId", "ChapterName", student.VaChapter);
            return View(student);
        }

        // GET: Students/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            ViewBag.Degree = new SelectList(db.DegreeTitles, "DegreeId", "DegreeName", student.Degree);
            ViewBag.DegreeType = new SelectList(db.DegreeTypes, "TypeId", "DegreeType1", student.DegreeType);
            ViewBag.VaChapter = new SelectList(db.VaChapters, "ChapterId", "ChapterName", student.VaChapter);
            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StudentId,QuarterStart,StudentNumber,FirstName,MiddleName,LastName,Gender,DOB,DegreeType,Degree,VaChapter,Adress,City,State,ZipCode,PhoneNumber,AltPhone,Email,AltEmail")] Student student)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Degree = new SelectList(db.DegreeTitles, "DegreeId", "DegreeName", student.Degree);
            ViewBag.DegreeType = new SelectList(db.DegreeTypes, "TypeId", "DegreeType1", student.DegreeType);
            ViewBag.VaChapter = new SelectList(db.VaChapters, "ChapterId", "ChapterName", student.VaChapter);
            return View(student);
        }

        // GET: Students/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Student student = db.Students.Find(id);
            db.Students.Remove(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
