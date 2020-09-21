using SheClean.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SheClean.Application.ViewModels
{
    public class AufenthaltViewModel
    {
        public IEnumerable<Aufenthalt> Aufenthalte { get; set; }
    }
}
