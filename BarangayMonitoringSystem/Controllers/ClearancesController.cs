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
    public class ClearancesController : Controller
    {
        private BarangayMonitoringSystemContext db = new BarangayMonitoringSystemContext();

        // GET: Clearances
        public ActionResult Index()
        {
          

            return View(db.Clearances.ToList());
        }

        // GET: Clearances/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clearances clearances = db.Clearances.Find(id);
            if (clearances == null)
            {
                return HttpNotFound();
            }
            return View(clearances);
        }

        // GET: Clearances/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clearances/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ClearanceId,ResidentId,Residentname,Cedula,BarangayId,RegisteredVoter,BGClearance")] Clearances clearances)
        {
            if (ModelState.IsValid)
            {
                db.Clearances.Add(clearances);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clearances);
        }

        // GET: Clearances/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clearances clearances = db.Clearances.Find(id);
            if (clearances == null)
            {
                return HttpNotFound();
            }
            return View(clearances);
        }

        // POST: Clearances/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ClearanceId,ResidentId,Residentname,Cedula,BarangayId,RegisteredVoter,BGClearance")] Clearances clearances)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clearances).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clearances);
        }

        // GET: Clearances/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clearances clearances = db.Clearances.Find(id);
            if (clearances == null)
            {
                return HttpNotFound();
            }
            return View(clearances);
        }

        // POST: Clearances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Clearances clearances = db.Clearances.Find(id);
            db.Clearances.Remove(clearances);
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
