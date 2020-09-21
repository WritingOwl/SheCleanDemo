using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SheClean.Domain.Models
{
    public class Aufenthalt
    {
        [Key]
        public int AufenthaltId { get; set; }
        public int PatientId { get; set; }
        public string FallNr { get; set; }
        public DateTime Datum { get; set; }
        public Patient Patient { get; set; }
    }
}
