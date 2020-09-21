using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SheClean.Domain.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string PatentNr { get; set; }
        public string ImageUrl { get; set; }
        public List<Aufenthalt> Aufenthalte { get; set; }
    }
}
