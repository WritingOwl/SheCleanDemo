using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using SheClean.Domain.Models;

namespace SheClean.Infra.Data.Context
{
    public class SheDBContext : DbContext
    {
        public SheDBContext(DbContextOptions options) : base(options)
        {
           
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Aufenthalt> Aufenthalte { get; set; }
        //Aufenthalt und Fremdschlüssel (Verheiraten)
    }
}
