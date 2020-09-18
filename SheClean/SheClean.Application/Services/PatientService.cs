using SheClean.Application.Interfaces;
using SheClean.Application.ViewModels;
using SheClean.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SheClean.Application.Services
{
    public class PatientService : IPatientService
    {
        private IPatientRepository _patientRepository;
        public PatientService(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public PatientViewModel GetPatients()
        {
            return new PatientViewModel()
            {
                Patients = _patientRepository.GetPatients()
            };
        }
    }
}
