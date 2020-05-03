using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BarangayMonitoringSystem.Models;

namespace BarangayMonitoringSystem.Controllers
{
    public class BlotterreportsController : Controller
    {
        private BarangayMonitoringSystemContext db = new BarangayMonitoringSystemContext();

        // GET: Blotterreports
        public ActionResult Index(string sortOrder, string searchString)
        {
            var incidents = from s in db.Blotterreports
                            select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                incidents = incidents.Where(s => s.ResidentLastName.Contains(searchString)
                                       || s.ResidentFirstName.Contains(searchString)
                                       || s.DateIncident.Contains(searchString)
                                       || s.Datereported.Contains(searchString)
                                       || s.Incidenttype.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    incidents = incidents.OrderByDescending(s => s.ResidentLastName);
                    break;
                case "Date":
                    incidents = incidents.OrderBy(s => s.DateIncident);
                    break;
                case "date_desc":
                    incidents = incidents.OrderByDescending(s => s.DateIncident);
                    break;
                default:
                    incidents = incidents.OrderBy(s => s.ResidentLastName);
                    break;
            }
            return View(db.Blotterreports.ToList());
        }

        // GET: Blotterreports/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blotterreports blotterreports = db.Blotterreports.Find(id);
            if (blotterreports == null)
            {
                return HttpNotFound();
            }
            return View(blotterreports);
        }

        // GET: Blotterreports/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Blotterreports/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id ,Blotternumber,ResidentName,ResidentFirstName,ResidentMiddleName,ResidentLastName,Incidentlocation,Incidenttype,Status,Remarks,Datereported,DateIncident")] Blotterreports blotterreports)
        {
            if (ModelState.IsValid)
            {
                db.Blotterreports.Add(blotterreports);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(blotterreports);
        }

        // GET: Blotterreports/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blotterreports blotterreports = db.Blotterreports.Find(id);
            if (blotterreports == null)
            {
                return HttpNotFound();
            }
            return View(blotterreports);
        }

        // POST: Blotterreports/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Blotternumber,Id, ResidentName,ResidentFirstName,ResidentMiddleName,ResidentLastName,Incidentlocation,Incidenttype,Status,Remarks,Datereported,DateIncident")] Blotterreports blotterreports)
        {
            if (ModelState.IsValid)
            {
                db.Entry(blotterreports).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(blotterreports);
        }

        // GET: Blotterreports/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blotterreports blotterreports = db.Blotterreports.Find(id);
            if (blotterreports == null)
            {
                return HttpNotFound();
            }
            return View(blotterreports);
        }

        // POST: Blotterreports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Blotterreports blotterreports = db.Blotterreports.Find(id);
            db.Blotterreports.Remove(blotterreports);
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
