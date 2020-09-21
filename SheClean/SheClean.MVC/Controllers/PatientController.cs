using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SheClean.Application.Interfaces;
using SheClean.Application.ViewModels;

namespace SheClean.MVC.Controllers
{
    public class PatientController : Controller
    {
        private readonly IPatientService _patientService;
        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }
        public IActionResult Index()
        {
            PatientViewModel model = _patientService.GetPatient();
            return View(model);
        }
    }
}
