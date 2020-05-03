﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BarangayMonitoringSystem.Models;
namespace BarangayMonitoringSystem.Controllers
{
    public class ResidentController : Controller
    {
        // GET: Resident
        public ActionResult Resident()
        {

            ViewBag.ResidentRegister = "Registered Residents";

            List<ResidentRegister> ResidentList = new List<ResidentRegister>()
            {
                 new ResidentRegister {ID = 1, ResidentFirstName = "Recy",
                     ResidentLastName ="Dequiros", ResidentMiddleName = "C.",
                     Age = 19, Address = "Caloocan", Birthdate = "May 20,2000",
                     Status = "Single", Nationality = "Filipino", Religion = "Catholic" , Occupation = "Student", PlaceofBirth = "Caloocan"},

                new ResidentRegister {ID = 2, ResidentFirstName = "Kaila",
                    ResidentLastName ="David",  ResidentMiddleName = "Ariza", Age = 20, Address = "Sindalan", Birthdate = "Septober",
                     Status = "In a Relationship", Nationality = "Filipino", Religion = "Catholic", Occupation = "Student" , PlaceofBirth = "San Fernando"},

                new ResidentRegister {ID = 3, ResidentFirstName = "John",
                    ResidentLastName ="Doe", ResidentMiddleName = "Smith", Age = 25, Address = "Angeles City", Birthdate = "Decembary",
                     Status = "Single", Nationality = "Filipino", Religion = "Catholic" , Occupation = "Teacher" , PlaceofBirth = "Sto.Cristo"},

                new ResidentRegister {ID = 4, ResidentFirstName = "Erwin",
                    ResidentLastName = "Galura",  ResidentMiddleName = "M.", Age = 19, Address = "Pandan", Birthdate = "May 10,2000",
                     Status = "Single", Nationality = "Filipino", Religion = "Catholic", Occupation = "Student" , PlaceofBirth = "Pampanga" },

                   new ResidentRegister {ID = 5, ResidentFirstName = "Covid",
                    ResidentLastName ="Mers",  ResidentMiddleName = "Bryant", Age = 19, Address = "China", Birthdate = "March 20,2020",
                     Status = "Single", Nationality = "Chinese", Religion = "Catholic" , Occupation = "Doctor", PlaceofBirth = "Wuhan" },
            };
            return View(ResidentList);
        }
        public ActionResult Viewresidents()
        {
            ViewBag.Message = "Resident Info.";

            List<ResidentRegister> ResidentList = new List<ResidentRegister>()
            {
                 new ResidentRegister {ID = 1, ResidentFirstName = "Recy",
                     ResidentLastName ="Dequiros", ResidentMiddleName = "C.",
                     Age = 19, Address = "Caloocan", Birthdate = "May 20,2000",
                     Status = "Single", Nationality = "Filipino", Religion = "Catholic" , Occupation = "Student", PlaceofBirth = "Caloocan"},

                new ResidentRegister {ID = 2, ResidentFirstName = "Kaila",
                    ResidentLastName ="David",  ResidentMiddleName = "Ariza", Age = 20, Address = "Sindalan", Birthdate = "Septober",
                     Status = "In a Relationship", Nationality = "Filipino", Religion = "Catholic", Occupation = "Student" , PlaceofBirth = "San Fernando"},

                new ResidentRegister {ID = 3, ResidentFirstName = "John",
                    ResidentLastName ="Doe", ResidentMiddleName = "Smith", Age = 25, Address = "Angeles City", Birthdate = "Decembary",
                     Status = "Single", Nationality = "Filipino", Religion = "Catholic" , Occupation = "Teacher" , PlaceofBirth = "Sto.Cristo"},

                new ResidentRegister {ID = 4, ResidentFirstName = "Erwin",
                    ResidentLastName = "Galura",  ResidentMiddleName = "M.", Age = 19, Address = "Pandan", Birthdate = "May 10,2000",
                     Status = "Single", Nationality = "Filipino", Religion = "Catholic", Occupation = "Student" , PlaceofBirth = "Pampanga" },

                   new ResidentRegister {ID = 5, ResidentFirstName = "Covid",
                    ResidentLastName ="Mers",  ResidentMiddleName = "Bryant", Age = 19, Address = "China", Birthdate = "March 20,2020",
                     Status = "Single", Nationality = "Chinese", Religion = "Catholic" , Occupation = "Doctor", PlaceofBirth = "Wuhan" },
            };
            return View(ResidentList);
        }
    }
}