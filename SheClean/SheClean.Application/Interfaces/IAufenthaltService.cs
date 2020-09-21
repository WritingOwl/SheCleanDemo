using SheClean.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SheClean.Application.Interfaces
{
    public interface IAufenthaltService
    {
        AufenthaltViewModel GetAufenthalt();
    }
}
