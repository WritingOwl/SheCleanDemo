using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SheClean.Application.Interfaces;
using SheClean.Application.ViewModels;

namespace SheClean.MVC.Controllers
{
    public class AufenthaltController : Controller
    {
        private readonly IAufenthaltService _aufenthaltService;
        public AufenthaltController(IAufenthaltService aufenthaltService)
        {
            _aufenthaltService = aufenthaltService;
        }
        public IActionResult Index()
        {
            AufenthaltViewModel model = _aufenthaltService.GetAufenthalt();
            return View(model);
        }
    }
}
