using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrisonMIS.Server.Contract.Financial;
using OrisonMIS.Shared.Entities.Financial;
using OrisonMIS.Shared.Entities.General;


namespace OrisonMIS.Server.Controllers.Financial
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcctStmtController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private IAccStmt _repository;
        public AcctStmtController( IWebHostEnvironment environment, IAccStmt repository)
        {
            _environment = environment;
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));

        }
        //Statement Details
        // GET: api/AcctStmt?AccountID=121812&BranchId=31&_FD=01-09-2020&_TD=31-12-2020
        [HttpGet]
        public async Task<IActionResult> Get(long AccountID, long BranchId, string _FD, string _TD,StatementType statementType, string key)
        {

            DateTime _FDate = Convert.ToDateTime(_FD);
            DateTime _TDate = Convert.ToDateTime(_TD);
            
            var statement =  await _repository.Show(BranchId, _FDate, _TDate, AccountID,statementType,key);
            return Ok(statement);

        }
        // GET: api/AcctStmt/31
        [HttpGet]
        [Route("GetBank")]
        public async Task<ActionResult<IEnumerable<BankDetails>>> GetBank(long BranchId, string key)
        {
            var AcctStmt = new List<BankDetails>();
            try
            {
                AcctStmt = await _repository.ShowBank(BranchId, key);
            }
            catch (Exception ex)
            { }
            return AcctStmt;


        }
        //[HttpGet("{AccCategory}/{BranchId}/{key}")]
        [HttpGet]
        [Route("GetYearwise")]
        public async Task<ActionResult<IEnumerable<BankDetails>>> GetYearwise(string AccCategory, long BranchId, string key)
        {
            var AcctStmt = new List<BankDetails>();
            try
            {
                AcctStmt = await _repository.ShowYearwise(AccCategory, BranchId, key);
            }
            catch (Exception ex)
            { }
            return AcctStmt;


        }
        // GET: api/AcctStmt/01-09-2020/31-12-2020/31
        //[HttpGet("{FD}/{TD}/{BranchId}/{key}")]
        [HttpGet]
        [Route("GetMonthlyProfit")]
        public async Task<ActionResult<IEnumerable<MonthlyProfit>>> GetMonthlyProfit(long BranchId, string FD, string TD, string key)
        {
            DateTime _FDate, _TDate;
            var AcctStmt = new List<MonthlyProfit>();
            string d = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            _FDate = DateTime.ParseExact(FD.Replace('-', '/'), d, System.Globalization.CultureInfo.CurrentCulture);
            _TDate = DateTime.ParseExact(TD.Replace('-', '/'), d, System.Globalization.CultureInfo.CurrentCulture);
            try
            {
                AcctStmt = await _repository.ShowProfit(BranchId, _FDate, _TDate, key);
            }
            catch (Exception ex)
            { }
            return AcctStmt;


        }
        // GET: api/AcctStmt/01-09-2020/31-12-2020/31/2020-2021
        //[HttpGet("{FD}/{TD}/{BranchId}/{finyear}/{key}")]
        [HttpGet]
        [Route("GetBudget")]
        public async Task<ActionResult<IEnumerable<BudgetReg>>> GetBudget(long BranchId, string FD, string TD, string finyear, string key)
        {
            //DateTime _FDate, _TDate;
            var AcctStmt = new List<BudgetReg>();
            //string d = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            //_FDate = DateTime.ParseExact(FD.Replace('-', '/'), d, System.Globalization.CultureInfo.CurrentCulture);
            //_TDate = DateTime.ParseExact(TD.Replace('-', '/'), d, System.Globalization.CultureInfo.CurrentCulture);
            DateTime _FDate = Convert.ToDateTime(FD);
            DateTime _TDate = Convert.ToDateTime(TD);
            try
            {
                AcctStmt = await _repository.ShowBudget(BranchId, _FDate, _TDate, finyear, key);
                if (AcctStmt == null)
                    AcctStmt = new List<BudgetReg>();
            }
            catch (Exception ex)
            { }
            return AcctStmt;


        }
        // GET: api/AcctStmt/01-09-2020/31-12-2020/31/1/TB
        //[HttpGet("{FD}/{TD}/{BranchId}/{opening}/{SP}/{key}")]
        [HttpGet]
        [Route("GetTB")]
        public async Task<ActionResult<IEnumerable<TrialBal>>> GetTB(long BranchId, string FD, string TD, string opening, string SP, string key)
        {
            //DateTime _FDate, _TDate;
            var AcctStmt = new List<TrialBal>();
            //string d = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            //_FDate = DateTime.ParseExact(FD.Replace('-', '/'), d, System.Globalization.CultureInfo.CurrentCulture);
            //_TDate = DateTime.ParseExact(TD.Replace('-', '/'), d, System.Globalization.CultureInfo.CurrentCulture);
            DateTime _FDate = Convert.ToDateTime(FD);
            DateTime _TDate = Convert.ToDateTime(TD);
            try
            {
                AcctStmt = await _repository.ShowTB(BranchId, _FDate, _TDate, opening, key);
            }
            catch (Exception ex)
            { }
            return AcctStmt;


        }
        [HttpGet]
        [Route("GetTBDetailed")]
        public async Task<ActionResult<IEnumerable<TrialBal>>> GetTBDetailed(long BranchId, string FD, string TD, string opening, string SP, string key)
        {
            //DateTime _FDate, _TDate;
            var AcctStmt = new List<TrialBal>();
            //string d = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            //_FDate = DateTime.ParseExact(FD.Replace('-', '/'), d, System.Globalization.CultureInfo.CurrentCulture);
            //_TDate = DateTime.ParseExact(TD.Replace('-', '/'), d, System.Globalization.CultureInfo.CurrentCulture);
            DateTime _FDate = Convert.ToDateTime(FD);
            DateTime _TDate = Convert.ToDateTime(TD);
            try
            {
                AcctStmt = await _repository.GetTBDetailed(BranchId, _FDate, _TDate, opening, key);
            }
            catch (Exception ex)
            { }
            return AcctStmt;


        }
        [HttpGet]
        [Route("StaffAccounts")]
        public async Task<ActionResult<List<dtInvAccounts>>> GetStaffAccounts(long BranchId, string key)
        {
           
             return await _repository.GetStaffAccounts(BranchId, key);
           
        } 
        [HttpGet]
        [Route("check-permission-and-get-staff-account")]
        public async Task<ActionResult<List<dtInvAccounts>>> CheckPermissionAndGetStaffAccount(int userId, string keyWord, string module, int branchId, string userCategory,string key)
        {
           
             return await _repository.CheckPermissionAndGetStaffAccount(userId, keyWord, module, branchId,userCategory,key);
           
        }
       
    }
}
