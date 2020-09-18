using SheClean.Domain.Interfaces;
using SheClean.Domain.Models;
using SheClean.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace SheClean.Infra.Data.Repository
{
    public class PatientRepository : IPatientRepository
    {
        private SheDBContext _ctx;
        public PatientRepository(SheDBContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Patient> GetPatient()
        {
            return _ctx.Patients;
        }
    }
}
