using SheClean.Application.Interfaces;
using SheClean.Application.ViewModels;
using SheClean.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SheClean.Application.Services
{
    public class AufenthaltService : IAufenthaltService
    {
        private IAufenthaltRepository _aufenthaltRepository;
        public AufenthaltService(IAufenthaltRepository aufenthaltRepository)
        {
            _aufenthaltRepository = aufenthaltRepository;
        }

        public AufenthaltViewModel GetAufenthalt()
        {
            return new AufenthaltViewModel()
            {
                Aufenthalte = _aufenthaltRepository.GetAufenthalt()
            };
        }
    }
}
