using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BarangayMonitoringSystem.Models;

namespace BarangayMonitoringSystem.Controllers
{
    public class RegisterController : Controller
    {

        // GET: Register
        public ActionResult Index()
        {
            var residents = from e in resList
                            orderby e.ID
                            select e;
            return View(residents);
        }

        // GET: Register/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {

            }
            return View();
        }

        // GET: Register/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Register/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            ResidentRegister residents = new ResidentRegister();

            try
            {

                UpdateModel(residents);

                residents.ID = Convert.ToInt32(collection["ID"]);
                residents.ResidentFirstName = collection["First Name"];
                residents.ResidentMiddleName = collection["Middle Name"];
                residents.ResidentLastName = collection["Last Name"];
                residents.Age = Convert.ToInt32(collection["Age"]);
                residents.Address = collection["Address"];
                residents.Nationality = collection["Nationality"];
                residents.Occupation = collection["Occupation"];
                residents.Religion = collection["Religion"];
                residents.Status = collection["Status"];
                residents.Birthdate = collection["Date of Birth"];
                residents.PlaceofBirth = collection["Place of Birth"];
                residents.Contactnumber = collection["Contact Number"];

                return RedirectToAction("Index");
            }
            catch
            {

              

                return View(residents);

                               
            }
}

        // GET: Register/Edit/5
        public ActionResult Edit(int id)
        {
            List<ResidentRegister> resList = GetResidentList();
            var residents = resList.Single(m => m.ID == id);
            return View(residents);
        }

        // POST: Register/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var residents = resList.Single(m => m.ID == id);
                if (TryUpdateModel(residents))
                {
                    //To Do:- database code
                    return RedirectToAction("Index");
                }
                return View(residents);
            }
            catch
            {
                return View();
            }
        }

        // GET: Register/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Register/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }


        }

        public List<ResidentRegister> GetResidentList()
        {
            return new List<ResidentRegister>{
      new ResidentRegister{
         ID = 1,
         ResidentFirstName = "Allan",
         ResidentMiddleName = "Ves",
          ResidentLastName = "Roche",
         Birthdate = Convert.ToString (DateTime.Parse(DateTime.Today.ToString())),
         Age = 23,
           Status = "Broken",
           Occupation = "Manager",
            Address = "123 Playground Street",
         Religion = "Catholic",
         Nationality = "Filipino",
         PlaceofBirth = "Whiterun",
      },

      new ResidentRegister{
         ID = 2,
           ResidentFirstName = "Laura",
         ResidentMiddleName = "Willingham",
          ResidentLastName = "Bailey",
         Birthdate = Convert.ToString (DateTime.Parse(DateTime.Today.ToString())),
         Age = 45,
           Status = "Broken",
           Occupation = "Media Artist",
            Address = "123 Playground Street",
          Religion = "Catholic",
         Nationality = "Filipino",
          PlaceofBirth = "Whiterun",
      },

      new ResidentRegister{
         ID = 3,
           ResidentFirstName = "Maria",
         ResidentMiddleName = "Gehrman",
          ResidentLastName = "Evetta",
          Birthdate = Convert.ToString (DateTime.Parse(DateTime.Today.ToString())),
         Age = 37,
          Status = "Broken",
           Occupation = "Businesswoman",
            Address = "123 Playground Street",
          Religion = "Catholic",
         Nationality = "Filipino",
         PlaceofBirth = "Yharnam",
      },

      new ResidentRegister{
         ID = 4,
          ResidentFirstName = "Sam",
         ResidentMiddleName = "Gabriel",
          ResidentLastName = "Fisher",
          Birthdate = Convert.ToString (DateTime.Parse(DateTime.Today.ToString())),
         Age = 26,
           Status = "Broken",
           Occupation = "Police Officer",
         Address = "123 Playground Street",
          Religion = "Catholic",
         Nationality = "Filipino",
         PlaceofBirth = "Echelon",

      },
   };


        }
        public static List<ResidentRegister> resList = new List<ResidentRegister>{
   new ResidentRegister{
      ID = 1,
         ResidentFirstName = "Allan",
         ResidentMiddleName = "Ves",
          ResidentLastName = "Roche",
         Birthdate = Convert.ToString (DateTime.Parse(DateTime.Today.ToString())),
         Age = 23,
           Status = "Broken",
           Occupation = "Manager",
            Address = "123 Playground Street",
         Religion = "Catholic",
         Nationality = "Filipino",
         PlaceofBirth = "Whiterun",
      },

    new ResidentRegister{
         ID = 2,
           ResidentFirstName = "Laura",
         ResidentMiddleName = "Willingham",
          ResidentLastName = "Bailey",
         Birthdate = Convert.ToString (DateTime.Parse(DateTime.Today.ToString())),
         Age = 45,
           Status = "Broken",
           Occupation = "Media Artist",
            Address = "123 Playground Street",
          Religion = "Catholic",
         Nationality = "Filipino",
          PlaceofBirth = "Whiterun",
      },

   new ResidentRegister{
         ID = 3,
           ResidentFirstName = "Maria",
         ResidentMiddleName = "Gehrman",
          ResidentLastName = "Evetta",
          Birthdate = Convert.ToString (DateTime.Parse(DateTime.Today.ToString())),
         Age = 37,
          Status = "Broken",
           Occupation = "Businesswoman",
            Address = "123 Playground Street",
          Religion = "Catholic",
         Nationality = "Filipino",
         PlaceofBirth = "Yharnam",
      },
    new ResidentRegister{
         ID = 4,
          ResidentFirstName = "Sam",
         ResidentMiddleName = "Gabriel",
          ResidentLastName = "Fisher",
          Birthdate = Convert.ToString (DateTime.Parse(DateTime.Today.ToString())),
         Age = 26,
           Status = "Broken",
           Occupation = "Police Officer",
         Address = "123 Playground Street",
          Religion = "Catholic",
         Nationality = "Filipino",
         PlaceofBirth = "Echelon",

      },

};
      

    }
}
