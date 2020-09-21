using System;
using System.Collections.Generic;
using System.Text;

namespace SheClean.Domain.Models
{
    public class Aufenthalt
    {
        public int AufenthaltId { get; set; }
        public int PatientId { get; set; }
        public string FallNr { get; set; }
        public DateTime Datum { get; set; }
        public Patient Patient { get; set; }
    }
}
