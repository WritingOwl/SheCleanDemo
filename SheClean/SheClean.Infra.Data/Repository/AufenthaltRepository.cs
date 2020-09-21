using SheClean.Domain.Interfaces;
using SheClean.Domain.Models;
using SheClean.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace SheClean.Infra.Data.Repository
{
    public class AufenthaltRepository : IAufenthaltRepository
    {
        private SheDBContext _ctx;
        public AufenthaltRepository(SheDBContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Aufenthalt> GetAufenthalt()
        {
            return _ctx.Aufenthalte;
        }
    }
}
