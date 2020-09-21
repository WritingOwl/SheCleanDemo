﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SheClean.Domain.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string PatientNr { get; set; }
        public string ImageUrl { get; set; }
        public List<Aufenthalt> Aufenthalte { get; set; }
    }
}
