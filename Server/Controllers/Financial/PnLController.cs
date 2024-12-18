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
    public class PnLController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private IPnL _repository;
        public PnLController( IWebHostEnvironment environment, IPnL repository)
        {
            _environment = environment;
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));

        }
        // GET: api/PnL?BranchId=31&_FD=01-09-2020&_TD=02-01-2021&Double=1&SP=PnL
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PnL>>> Get(long BranchId, string _FD, string _TD, int Double, string SP, string key)
        {
            //DateTime _FDate, _TDate;
            var AcctStmt = new List<PnL>();
            //string d = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            //_FDate = DateTime.ParseExact(_FD.Replace('-', '/'), d, System.Globalization.CultureInfo.CurrentCulture);
            //_TDate = DateTime.ParseExact(_TD.Replace('-', '/'), d, System.Globalization.CultureInfo.CurrentCulture);
            DateTime _FDate = Convert.ToDateTime(_FD);
            DateTime _TDate = Convert.ToDateTime(_TD);
            try
            {
                AcctStmt = await _repository.Show(BranchId, _FDate, _TDate, Double, SP,key);
            }
            catch (Exception ex)
            { }
            return AcctStmt;


        }
    }
}
