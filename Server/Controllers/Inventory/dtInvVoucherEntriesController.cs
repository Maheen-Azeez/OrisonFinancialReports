using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrisonMIS.Server.Contract.Inventory;
using OrisonMIS.Shared.Entities.Inventory;


namespace OrisonMIS.Server.Controllers.Inventory
{
    [Route("api/[controller]")]
    [ApiController]
    public class dtInvVoucherEntriesController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private IInvVoucherEntryManager _repository;

        public dtInvVoucherEntriesController( IWebHostEnvironment environment, IInvVoucherEntryManager repository)
        {
            _environment = environment;
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));

        }
        // GET: api/dtInvVoucherEntries?VId=10293
        [HttpGet]
        public async Task<ActionResult<IEnumerable<dtInvVoucherEntry>>> GetVoucherEntry(long VId, string key)
        {
            return await _repository.GetVoucherEntry(VId,key);

        }
    }
}
