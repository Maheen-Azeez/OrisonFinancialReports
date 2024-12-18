using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrisonMIS.Server.Contract.Financial;
using OrisonMIS.Shared.Entities.Financial;


namespace OrisonMIS.Server.Controllers.Financial
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillwiseStmtController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private IBillWiseStmt _repository;
        public BillwiseStmtController(IWebHostEnvironment environment, IBillWiseStmt repository)
        {
            _environment = environment;
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));

        }
        // GET: api/BillwiseStmt?AccountID=214147&BranchId=31&_FD=01-09-2020&_TD=31-12-2020
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BillwiseStmt>>> Get(long AccountID, long BranchId, string _FD, string _TD, string key)
        {
            DateTime _FDate, _TDate;
            var AcctStmt = new List<BillwiseStmt>();
            string d = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            _FDate = DateTime.ParseExact(_FD.Replace('-', '/'), d, System.Globalization.CultureInfo.CurrentCulture);
            _TDate = DateTime.ParseExact(_TD.Replace('-', '/'), d, System.Globalization.CultureInfo.CurrentCulture);
            try
            {
                AcctStmt = await _repository.Show(BranchId, _FDate, _TDate, AccountID, key);
            }
            catch (Exception ex)
            { }
            return AcctStmt;
        }
    }
}
