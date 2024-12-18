using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrisonMIS.Server.Contract.VAT;
using OrisonMIS.Shared.Entities.VAT;

namespace OrisonMIS.Server.Controllers.VAT
{
    [Route("api/[controller]")]
    [ApiController]
    public class VatController : ControllerBase
    {
        private readonly IVatManager vatManager;

        public VatController(IVatManager vatManager)
        {
            this.vatManager = vatManager;
        }
        [HttpGet]
        [Route("VatReport")]
        public async Task<ActionResult<VatReportsDto>> GetVatReports(DateTime dateFrom, DateTime dateTo, int branchid,string key)
        {
            VatReportsDto reports = await vatManager.getVatReports(dateFrom, dateTo, branchid, key);
            return Ok(reports);
        }
    }
}
