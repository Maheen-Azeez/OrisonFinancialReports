using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrisonMIS.Server.Contract.Inventory;

namespace OrisonMIS.Server.Controllers.Inventory
{
    [Route("api/[controller]")]
    [ApiController]
    public class dtInvVouchersController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private IInvVoucherManager _repository;
        public dtInvVouchersController( IWebHostEnvironment environment, IInvVoucherManager repository)//, IInvVoucherAdditionalsManager VARepository, IInvTransactionsManager TranRepository)
        {
            _environment = environment;
            _repository = repository ?? throw new ArgumentNullException(nameof(_repository));

        }
        // GET: api/dtInvVouchers?vid=10293
        [HttpGet]
        public async Task<IActionResult> Get(long VId, string key)

        {
            return Ok(await _repository.GetVoucher(VId,key));
        }
    }
}
