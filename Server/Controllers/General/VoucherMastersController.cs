using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Shared.Entities.General;


namespace OrisonMIS.Server.Controllers.General
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoucherMastersController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private IVoucherMasterManager _repository;
        public VoucherMastersController( IWebHostEnvironment environment, IVoucherMasterManager repository)
        {
            _environment = environment;
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));

        }
        // GET: api/VoucherMasters?vtype=75
        //[HttpGet("{vtype}/{key}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<dtVoucherMaster>>> GetVoucherMaster(int vtype, int BranchID, string key)//, int userid)
        {
            return await _repository.ListAll(vtype, 62, BranchID,key);

        }
        //[HttpGet("{_vtype}/{_userid}/{_FD}/{_TD}/{BranchID}/{Criteria}/{key}")]
        [HttpGet]
        [Route("GetVoucherMaster")]
        public async Task<ActionResult<IEnumerable<dtVoucherMaster>>> GetVoucherMaster1(int _vtype, int _userid, string _FD, string _TD, int BranchID, string Criteria, string key)
        {
            DateTime _FDate, _TDate;
            string d = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            _FDate = DateTime.ParseExact(_FD.Replace('-','/'), d, System.Globalization.CultureInfo.CurrentCulture);
            _TDate = DateTime.ParseExact(_TD.Replace('-', '/'), d, System.Globalization.CultureInfo.CurrentCulture);
            // _FDate = Convert.ToDateTime(_FD);
            // _TDate = Convert.ToDateTime(_TD);
            return await _repository.Register(_vtype, _userid, _FDate, _TDate, BranchID, Criteria,key);
            //return await _context.VoucherMaster.ToListAsync();
        }
        //[HttpGet("{SBasicType}/{DBasicType}/{BranchID}/{Criteria}/{User}/{key}")]
        [HttpGet]
        [Route("GetImportVoucher")]
        public async Task<ActionResult<IEnumerable<dtVoucherMaster>>> GetImportVoucher(string SBasicType, string DBasicType, int BranchID, string Criteria, int User, string key)
        {

            return await _repository.ImportVoucher(SBasicType, DBasicType, BranchID, Criteria, User,key);
        }
        //[HttpGet("{id}/{userid}/{BranchID}/{key}")]
        public async Task<long> GetVoucherMaster1(int id, int userid, int BranchID, string key)
        {
            return await _repository.ListById(id, userid, BranchID,key);
        }

        //[HttpGet("{id}/{userid}/{VNo}/{BranchID}/{key}")]
        public async Task<long> GetVoucherMastervNo(int id, int userid, string VNo, int BranchID, string key)
        {
            return await _repository.ListByVNo(id, userid, VNo,BranchID,key);
        }
        //[HttpGet("{_vtype}/{_userid}")]
        //public async Task<ActionResult<IEnumerable<dtVoucherMaster>>> GetVoucherMasterReceipt(int _vtype, int _userid)
        //{
        //    return await _repository.ReceiptList(_vtype, _userid);
        //    //return await _context.VoucherMaster.ToListAsync();
        //}
        //public async Task<ActionResult<IEnumerable<dtVoucherMaster>>> GetVoucherMasterReceipt(int _vtype, int _userid, string _FD, string _TD)
        //{
        //    int d, m, y;
        //    string[] SD = _FD.Split("-");
        //    d = int.Parse(SD[0]);
        //    m = int.Parse(SD[1]);
        //    y = int.Parse(SD[2]);
        //    _FD = m.ToString("00") + "-" + d.ToString("00") + "-" + y.ToString("0000");
        //    string[] ED = _TD.Split("-");
        //    d = int.Parse(ED[0]);
        //    m = int.Parse(ED[1]);
        //    y = int.Parse(ED[2]);
        //    _TD = m.ToString("00") + "-" + d.ToString("00") + "-" + y.ToString("0000");
        //    DateTime _FDate, _TDate;
        //    _FDate = Convert.ToDateTime(_FD);
        //    _TDate = Convert.ToDateTime(_TD);
        //    return await _repository.ReceiptList(_vtype, _userid, _FDate, _TDate);
        //    //return await _context.VoucherMaster.ToListAsync();
        //}
    }
}
