using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrisonMIS.Server.Contract.Financial.Main;
using OrisonMIS.Shared.Entities.Financial;


namespace OrisonMIS.Server.Controllers.Financial.Main
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillsVwController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private IBillsVw _repository;
        public BillsVwController( IWebHostEnvironment environment, IBillsVw repository)
        {
            _environment = environment;
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));

        }

        // GET: api/BillsVw?AccId=48064&BranchId=31
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BillVw>>> Get(long AccId, long BranchId, string key)
        {
            return await _repository.ShowBills(AccId, BranchId, key);

        }
       
    }
}
