using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrisonMIS.Server.Contract.Financial;
using OrisonMIS.Shared.Entities.Financial;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Server.Controllers.Financial
{
    [Route("api/[controller]")]
    [ApiController]
    public class CashFlowController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private ICashFlow _repository;
        public CashFlowController(IWebHostEnvironment environment, ICashFlow repository)
        {
            _environment = environment;
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));

        }
        // GET: api/CashFlow?BranchId=31&_FD=01-09-2020&_TD=01-08-2021
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CashFlow>>> Get(long BranchId, string _FD, string _TD, string key)
        {
            DateTime _FDate, _TDate;
            var AcctStmt = new List<CashFlow>();
            string d = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            _FDate = DateTime.ParseExact(_FD.Replace('-', '/'), d, System.Globalization.CultureInfo.CurrentCulture);
            _TDate = DateTime.ParseExact(_TD.Replace('-', '/'), d, System.Globalization.CultureInfo.CurrentCulture);
            try
            {
                AcctStmt = await _repository.Show(BranchId, _FDate, _TDate, key);
            }
            catch (Exception ex)
            { }
            return AcctStmt;


        }
    }
}
