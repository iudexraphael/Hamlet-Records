namespace BarangayMonitoringSystem.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using BarangayMonitoringSystem.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<BarangayMonitoringSystem.Models.BarangayMonitoringSystemContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "BarangayMonitoringSystem.Models.BarangayMonitoringSystemContext";
        }

        protected override void Seed(BarangayMonitoringSystem.Models.BarangayMonitoringSystemContext context)
        {

            var residents = new List<ResidentRegister>()
           {

                 new ResidentRegister {ID = 1, ResidentFirstName = "Recy", Gender = "Female",
                     ResidentLastName ="Dequiros", ResidentMiddleName = "C.",
                     Age = 19, Address = "Caloocan", Birthdate = "May 20,2000", Contactnumber = "0999999",
                      Status = "Single", Nationality = "Filipino", Religion = "Catholic" , Occupation = "Student", PlaceofBirth = "Caloocan"},

                new ResidentRegister {ID = 2, ResidentFirstName = "Kaila", Contactnumber = "0999999", Gender = "Female",
                    ResidentLastName ="David",  ResidentMiddleName = "Ariza", Age = 20, Address = "Sindalan", Birthdate = "Septober",
                     Status = "In a Relationship", Nationality = "Filipino", Religion = "Catholic", Occupation = "Student" , PlaceofBirth = "San Fernando"},

                new ResidentRegister {ID = 3, ResidentFirstName = "John", Contactnumber = "0999999", Gender = "Male",
                    ResidentLastName ="Doe", ResidentMiddleName = "Smith", Age = 25, Address = "Angeles City", Birthdate = "Decembary",
                     Status = "Single", Nationality = "Filipino", Religion = "Catholic" , Occupation = "Teacher" , PlaceofBirth = "Sto.Cristo"},

                new ResidentRegister {ID = 4, ResidentFirstName = "Erwin", Contactnumber = "0999999", Gender = "Male",
                    ResidentLastName = "Galura",  ResidentMiddleName = "M.", Age = 19, Address = "Pandan", Birthdate = "May 10,2000",
                     Status = "Single", Nationality = "Filipino", Religion = "Catholic", Occupation = "Student" , PlaceofBirth = "Pampanga" },

                   new ResidentRegister {ID = 5, ResidentFirstName = "Covid", Contactnumber = "0999999",  Gender = "Male",
                    ResidentLastName ="Mers",  ResidentMiddleName = "Bryant", Age = 19, Address = "China", Birthdate = "March 20,2020",
                     Status = "Single", Nationality = "Chinese", Religion = "Catholic" , Occupation = "Doctor", PlaceofBirth = "Wuhan" },
            };
            residents.ForEach(s => context.ResidentRegisters.AddOrUpdate(p => p.ResidentLastName, s));
            context.SaveChanges();

            var reports = new List<Blotterreports>()
                        {
                  new Blotterreports {Blotternumber = 1, Id = 10, ResidentFirstName = "Kirvy",ResidentMiddleName = "Ziganay", ResidentLastName = "Muldong",
                     Incidentlocation = "Sapang Bato",
                     Incidenttype = "Breach", Status = "Pending", Remarks = "Lost of human life is tragic, even subhuman life",
                     Datereported = "04/05/2020", DateIncident = "04/4/2020 5:00PM"},

                  new Blotterreports {Blotternumber = 2, Id = 11, ResidentFirstName = "Erwin", ResidentMiddleName = "Magbata", ResidentLastName = "Galura",
                    Incidentlocation = "City Center",
                     Incidenttype = "Jaywalking", Status = "Resolved", Remarks = "Chalk one up for the good guys",
                     Datereported = "04/09/2020", DateIncident = "04/08/2020 1:00PM"},
            };
            reports.ForEach(s => context.Blotterreports.AddOrUpdate(p => p.Blotternumber, s));
            context.SaveChanges();


            foreach (ResidentRegister e in residents)
            {
                var ResidentinDb = context.ResidentRegisters.Where(
                    s =>
                         s.ID == e.ID).SingleOrDefault();
                if (ResidentinDb == null)
                {
                    context.ResidentRegisters.Add(e);
                }
            }
            context.SaveChanges();
        } 
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }

