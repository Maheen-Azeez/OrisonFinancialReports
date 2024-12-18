using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrisonMIS.Server.Contract.Financial.Main;


namespace OrisonMIS.Server.Controllers.Financial.Main
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoucherController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private IVoucher _repository;
        public VoucherController( IWebHostEnvironment environment, IVoucher repository)
        {
            _environment = environment;
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));

        }

        // GET: api/Voucher?VId=16534
        [HttpGet]

        public async Task<IActionResult> Get(long VId, string key)

        {
            return Ok(await _repository.ShowVoucher(VId, key));
        }
        //public async Task<ActionResult<IEnumerable<Voucher>>> Get(long VId)
        //{
        //    return await _repository.ShowVoucher(VId);

        //}
    }
}
