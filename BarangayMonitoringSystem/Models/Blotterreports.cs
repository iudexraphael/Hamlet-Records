using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace BarangayMonitoringSystem.Models
{
    public class Blotterreports
    {
        [Key]
        [Display(Name = "Blotter Number") Required]
        public int Blotternumber { get; set; }

        [Display(Name = "Resident ID") ]
        public int Id { get; set; }

        [Display(Name = "First Name") Required]
        public string ResidentFirstName { get; set; }

        [Display(Name = "Middle Name") Required]
        public string ResidentMiddleName { get; set; }

        [Display(Name = "Last Name") Required]
        public string ResidentLastName { get; set; }

        [Display(Name = "Incident Location") Required]
        public string Incidentlocation { get; set; }

        [Display(Name = "Incident Type") Required]
        public string Incidenttype { get; set; }

        [Display(Name = "Status") Required]
        public string Status { get; set; }

        public string Remarks { get; set; }

        [Display(Name = "Date Reported") Required]
        public string Datereported { get; set; }

        [Display(Name = "Date of Incident") Required]
        public string DateIncident { get; set; }

        //public virtual ICollection<Blotterreports> Blotter { get; set; }
    }
}