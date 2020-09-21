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
//hier sage ich, wie der Vertrag aussehen soll
//PatientRepository muss also GetPatient beinhalten und kann ausgetauscht werden, Vertrag bleibt gleich
//SERVICE