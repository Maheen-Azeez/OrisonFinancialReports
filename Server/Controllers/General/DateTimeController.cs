using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Shared.Entities.General;

namespace OrisonMIS.Server.Controllers.General
{
    [Route("api/[controller]")]
    [ApiController]
    public class DateTimeController : ControllerBase
    {
        private readonly IDateTimeRepository _repository;

        public DateTimeController(IDateTimeRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("getentryfromdatetime")]
        public async Task<ActionResult<DateTime>> GetEntryFromDateTime([FromQuery] int branchId, [FromQuery] string key)
        {
            var dateTime = await _repository.GetEntryFromDateTimeAsync(branchId,key);
            return Ok(dateTime);
        }

        [HttpGet("GetFinancialDateTime")]
        public async Task<ActionResult<FinancialDateTime>> GetFinancialDateTimeAsync([FromQuery] int branchId, [FromQuery] string key)
        {
            var dateTime = await _repository.GetFinancialDateTimeAsync(branchId, key);
            return Ok(dateTime);
        }
        [HttpGet("VatDateTime")]
        public async Task<ActionResult<DateTime>> GetVatDateTimeAsync([FromQuery] int branchId, [FromQuery] string key)
        {
            var dateTime = await _repository.GetVatDateTimeAsync(branchId, key);
            return Ok(dateTime);
        }
    }
}
