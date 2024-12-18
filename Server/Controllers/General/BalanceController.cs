using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using OrisonMIS.Server.Contract.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Server.Controllers.General
{
    [Route("api/[controller]")]
    [ApiController]
    public class BalanceController : Controller
    {
        private IWebHostEnvironment _environment;
        private IDBOperation _repository;
        public BalanceController( IWebHostEnvironment environment, IDBOperation repository)
        {
            _environment = environment;
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet("{AccId}/{_BranchId}/{key}")]
        public async Task<string> GetBalance(long AccId, int _BranchId,string key)
        {
            return await _repository.GetBalance(AccId, _BranchId,key);
        }
    }
}
