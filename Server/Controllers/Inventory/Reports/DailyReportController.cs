using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrisonMIS.Server.Contract.Inventory.Reports;


namespace OrisonMIS.Server.Controllers.Inventory.Reports
{
    [Route("api/[controller]")]
    [ApiController]
    public class DailyReportController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private IReportsManager _repository;
        public DailyReportController(IWebHostEnvironment environment, IReportsManager repository)
        {
            _environment = environment;
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));

        }
        [HttpGet("{_userid}/{_FD}/{_TD}/{key}")]
        public async Task<ActionResult<IEnumerable<object>>> DailyReport(int _userid, string _FD, string _TD, string key)
        {
            //int d, m, y;
            //string[] SD = _FD.Split("-");
            //d = int.Parse(SD[0]);
            //m = int.Parse(SD[1]);
            //y = int.Parse(SD[2]);
            //_FD = m.ToString("00") + "-" + d.ToString("00") + "-" + y.ToString("0000");
            //string[] ED = _TD.Split("-");
            //d = int.Parse(ED[0]);
            //m = int.Parse(ED[1]);
            //y = int.Parse(ED[2]);
            //_TD = m.ToString("00") + "-" + d.ToString("00") + "-" + y.ToString("0000");
            DateTime _FDate, _TDate;
            _FDate = Convert.ToDateTime(_FD);
            _TDate = Convert.ToDateTime(_TD);
            return await _repository.DailyReport(_userid, _FDate, _TDate,key);

        }
        [HttpGet("{_userid}/{_FD}/{_TD}/{_Crt}/{key}")]
        public async Task<ActionResult<IEnumerable<object>>> DailyReportDetailed(int _userid, string _FD, string _TD, string _Crt, string key)
        {
            //int d, m, y;
            //string[] SD = _FD.Split("-");
            //d = int.Parse(SD[0]);
            //m = int.Parse(SD[1]);
            //y = int.Parse(SD[2]);
            //_FD = m.ToString("00") + "-" + d.ToString("00") + "-" + y.ToString("0000");
            //string[] ED = _TD.Split("-");
            //d = int.Parse(ED[0]);
            //m = int.Parse(ED[1]);
            //y = int.Parse(ED[2]);
            //_TD = m.ToString("00") + "-" + d.ToString("00") + "-" + y.ToString("0000");
            DateTime _FDate, _TDate;
            _FDate = Convert.ToDateTime(_FD);
            _TDate = Convert.ToDateTime(_TD);
            return await _repository.DailyReportDetailed(_userid, _FDate, _TDate, _Crt,key);

        }
    }
}
