using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
namespace BarangayMonitoringSystem.Models
{
    public class Clearances
    {
        [Key]
        [Display(Name = "Clearance Id")]
        public int ClearanceId { get; set; }

        [Display(Name = "Resident ID")]
        public int ResidentId { get; set; }

        [Display(Name = "Resident Name")]
        public string Residentname { get; set; }

        public string Cedula { get; set; }

        [Display(Name = "Barangay ID")]
        public string  BarangayId { get; set; }

        [Display(Name = "Registered Voter")]
        public string RegisteredVoter { get; set; }

        [Display(Name = "Barangay Clearance")]
        public string BGClearance { get; set; }
    }
}