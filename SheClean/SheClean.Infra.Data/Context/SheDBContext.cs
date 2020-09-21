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
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Aufenthalt>()
               .HasOne(a => a.Patient )
               .WithMany(p => p.Aufenthalte )
               .HasForeignKey(a => a.PatientId);
                
        }
        //Aufenthalt und Fremdschlüssel (Verheiraten)
    }
}       
         