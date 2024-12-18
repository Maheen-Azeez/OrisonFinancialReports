using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using OrisonMIS.Server.Contract.Financial.Main;
using OrisonMIS.Shared.Entities.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Server.Controllers.Financial.Main
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceiptController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private IReceiptManager _repository;
        public ReceiptController(IWebHostEnvironment environment, IReceiptManager repository)
        {
            _environment = environment;
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<dtVoucherMaster>>> GetVoucherMasterReceipt(int _vtype, int Id, string key)
        {
            return await _repository.ReceiptList(_vtype, Id, key);
            //return await _context.VoucherMaster.ToListAsync();
        }
    }
}
