using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Shared.Entities.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Server.Controllers.General
{
    [Route("api/[controller]")]
    [ApiController]
    public class BudgetController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private IDBOperation _repository;
        public BudgetController( IWebHostEnvironment environment, IDBOperation repository)
        {
            _environment = environment;
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet("{AccId}/{Fiancialyear}/{_BranchId}/{key}")]
        public async Task<ActionResult<IEnumerable<Budget>>> GetBudget(long AccId, string Fiancialyear, int _BranchId, string key)
        {
            return await _repository.GetBudget(AccId, Fiancialyear, _BranchId,key);
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> GetFinYear(string key)
        {
            return await _repository.GetFinYear(key);
        }
        
    }
}
