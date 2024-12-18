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
    public class BalanceSheetController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private IBS _repository;
        public BalanceSheetController( IWebHostEnvironment environment, IBS repository)
        {
            _environment = environment;
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));

        }
        // GET: api/BalanceSheet?BranchId=31&_FD=01-01-2021&_TD=31-12-2021&_SP=BS
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BalanceSheet>>> GetBS(long BranchId, string _FD, string _TD, string _SP, string key)
        {
            //DateTime _FDate, _TDate;
            var AcctStmt = new List<BalanceSheet>();
            //string d = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            //_FDate = DateTime.ParseExact(_FD.Replace('-', '/'), d, System.Globalization.CultureInfo.CurrentCulture);
            //_TDate = DateTime.ParseExact(_TD.Replace('-', '/'), d, System.Globalization.CultureInfo.CurrentCulture);
            DateTime _FDate = Convert.ToDateTime(_FD);
            DateTime _TDate = Convert.ToDateTime(_TD);
            try
            {
                AcctStmt = await _repository.Show(BranchId, _FDate, _TDate, _SP, key);
            }
            catch (Exception ex)
            { }
            return AcctStmt;

        }
    }
}
