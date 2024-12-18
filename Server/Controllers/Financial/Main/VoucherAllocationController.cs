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
    public class VoucherAllocationController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private IVoucherAllocation _repository;
        public VoucherAllocationController( IWebHostEnvironment environment, IVoucherAllocation repository)
        {
            _environment = environment;
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));

        }

        // GET: api/VoucherAllocation?AccId=48064&VID=10546
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VoucherAllocation>>> Get(long AccId, long VID, string key)
        {
            return await _repository.ShowAllocation(AccId, VID, key);

        }

    }
}
