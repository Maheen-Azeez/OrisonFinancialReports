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
    public class dtInvVoucherAdditionalsController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private IInvVoucherAdditionalsManager _repository;
        public dtInvVoucherAdditionalsController(IWebHostEnvironment environment, IInvVoucherAdditionalsManager repository)
        {
            _environment = environment;
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));

        }

        // GET: api/dtInvVoucherAdditionals?VId=10293
        [HttpGet]
        public async Task<IActionResult> Get(long VId, string key)

        {
            return Ok(await _repository.GetVoucherAdditionals(VId,key));
        }
    }
}
