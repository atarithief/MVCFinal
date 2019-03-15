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
    public class DegreeTitlesController : Controller
    {
        private VeteransDBEntities db = new VeteransDBEntities();

        // GET: DegreeTitles
        public ActionResult Index()
        {
            return View(db.DegreeTitles.ToList());
        }

        // GET: DegreeTitles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DegreeTitle degreeTitle = db.DegreeTitles.Find(id);
            if (degreeTitle == null)
            {
                return HttpNotFound();
            }
            return View(degreeTitle);
        }

        // GET: DegreeTitles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DegreeTitles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DegreeId,DegreeName")] DegreeTitle degreeTitle)
        {
            if (ModelState.IsValid)
            {
                db.DegreeTitles.Add(degreeTitle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(degreeTitle);
        }

        // GET: DegreeTitles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DegreeTitle degreeTitle = db.DegreeTitles.Find(id);
            if (degreeTitle == null)
            {
                return HttpNotFound();
            }
            return View(degreeTitle);
        }

        // POST: DegreeTitles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DegreeId,DegreeName")] DegreeTitle degreeTitle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(degreeTitle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(degreeTitle);
        }

        // GET: DegreeTitles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DegreeTitle degreeTitle = db.DegreeTitles.Find(id);
            if (degreeTitle == null)
            {
                return HttpNotFound();
            }
            return View(degreeTitle);
        }

        // POST: DegreeTitles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DegreeTitle degreeTitle = db.DegreeTitles.Find(id);
            db.DegreeTitles.Remove(degreeTitle);
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
