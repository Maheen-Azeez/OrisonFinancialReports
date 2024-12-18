using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using OrisonMIS.Server.Contract.Financial.Main;
using OrisonMIS.Shared.Entities.Financial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Server.Controllers.Financial.Main
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountAllocationController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private IAccountAllocationManager _repository;
        public AccountAllocationController( IWebHostEnvironment environment, IAccountAllocationManager repository)
        {
            _environment = environment;
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<VoucherAllocation>>> Get(long AccId, long VID,string key)
        {
            return await _repository.AccountAllocation(AccId, VID,key);
        }
    }
}
