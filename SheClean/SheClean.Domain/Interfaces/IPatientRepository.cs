using SheClean.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SheClean.Domain.Interfaces
{
    public interface IPatientRepository
    {
       IEnumerable<Patient> GetPatient(); 
    }
}
