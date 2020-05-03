using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PagedList;
using BarangayMonitoringSystem.Models;

namespace BarangayMonitoringSystem.Controllers
{
    public class ResidentRegistersController : Controller
    {
        private BarangayMonitoringSystemContext db = new BarangayMonitoringSystemContext();

        // GET: ResidentRegisters
        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var residents = from s in db.ResidentRegisters
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                residents = residents.Where(s => s.ResidentLastName.Contains(searchString)
                                       || s.ResidentFirstName.Contains(searchString)
                                       || s.ResidentMiddleName.Contains(searchString)
                                       || s.Birthdate.Contains(searchString) 
                                       ||s.Address.Contains(searchString)
                                       || s.Nationality.Contains(searchString)
                                       || s.Religion.Contains(searchString)
                                       || s.Status.Contains(searchString)
                                       || s.ResidentFirstName.Contains(searchString)
                                       || s.Gender.StartsWith(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    residents = residents.OrderByDescending(s => s.ResidentLastName);
                    break;
                case "Date":
                    residents = residents.OrderBy(s => s.Birthdate);
                    break;
                case "date_desc":
                    residents = residents.OrderByDescending(s => s.Birthdate);
                    break;
                case "firstname":
                    residents = residents.OrderBy(s => s.ResidentFirstName);
                    break;
                case "firstname_desc":
                    residents = residents.OrderByDescending(s => s.ResidentFirstName);
                    break;
                case "middlename":
                    residents = residents.OrderByDescending(s => s.ResidentMiddleName);
                    break;
                default:
                    residents = residents.OrderBy(s => s.ResidentLastName);
                    break;
            }
          
            return View(residents.ToList());
        }


        // GET: ResidentRegisters/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResidentRegister residentRegister = db.ResidentRegisters.Find(id);
            if (residentRegister == null)
            {
                return HttpNotFound();
            }
            return View(residentRegister);
        }

        // GET: ResidentRegisters/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ResidentRegisters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ResidentFirstName,ResidentMiddleName,ResidentLastName,Age,Address, Gender, Religion,Status,Occupation,Nationality,Birthdate,PlaceofBirth, Contactnumber")] ResidentRegister residentRegister)
        {
            if (ModelState.IsValid)
            {
                db.ResidentRegisters.Add(residentRegister);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(residentRegister);
        }

        // GET: ResidentRegisters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResidentRegister residentRegister = db.ResidentRegisters.Find(id);
            if (residentRegister == null)
            {
                return HttpNotFound();
            }
            return View(residentRegister);
        }

        // POST: ResidentRegisters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ResidentFirstName,ResidentMiddleName,ResidentLastName,Age, Gender, Address,Religion,Status,Occupation,Nationality,Birthdate,PlaceofBirth,Contactnumber")] ResidentRegister residentRegister)
        {
            if (ModelState.IsValid)
            {
                db.Entry(residentRegister).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(residentRegister);
        }

        // GET: ResidentRegisters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResidentRegister residentRegister = db.ResidentRegisters.Find(id);
            if (residentRegister == null)
            {
                return HttpNotFound();
            }
            return View(residentRegister);
        }

        // POST: ResidentRegisters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ResidentRegister residentRegister = db.ResidentRegisters.Find(id);
            db.ResidentRegisters.Remove(residentRegister);
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
