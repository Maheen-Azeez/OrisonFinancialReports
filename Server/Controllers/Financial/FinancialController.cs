using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrisonMIS.Server.Contract.Financial;
using OrisonMIS.Shared.Entities;
using OrisonMIS.Shared.Entities.Financial;

namespace OrisonMIS.Server.Controllers.Financial
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinancialController : ControllerBase
    {
        private readonly IFinancialManager repository;

        public FinancialController(IFinancialManager repository)
        {
            this.repository = repository;
        }
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<dtFinancialRegister>>> Get(int BranchId, string _FD, string _TD, string key)
        //{
        //    DateTime _FDate, _TDate;
        //    var AcctStmt = new List<dtFinancialRegister>();
        //    string d = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
        //    _FDate = DateTime.ParseExact(_FD.Replace('-', '/'), d, System.Globalization.CultureInfo.CurrentCulture);
        //    _TDate = DateTime.ParseExact(_TD.Replace('-', '/'), d, System.Globalization.CultureInfo.CurrentCulture);
        //    try
        //    {
        //        AcctStmt = await repository.GetData(BranchId, _FDate, _TDate, key);
        //    }
        //    catch (Exception ex)
        //    { }
        //    return AcctStmt;


        //}
        [HttpGet]
        public async Task<ActionResult<dtFinancialRegisterPaging>> Get(int BranchId, DateTime _FD, DateTime _TD, int pageNumber, int pageSize, string Search, string action, string? VType, string key)
        {
            //DateTime _FDate, _TDate;
            //var AcctStmt = new List<dtFinancialRegister>();
            //string d = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            //_FDate = DateTime.ParseExact(_FD.Replace('-', '/'), d, System.Globalization.CultureInfo.CurrentCulture);
            //DateTime.TryParseExact(_TD, "MM-dd-yyyy", null, System.Globalization.DateTimeStyles.None, out _TDate);
            try
            {
                var result = await repository.GetData(BranchId, _FD, _TD, pageNumber, pageSize, Search, action, VType, key);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
        [HttpGet]
        [Route("GetTransaction")]
        public async Task<ActionResult<List<dtTransaction>>> GetTransaction(int BranchId, DateTime _FD, DateTime _TD,string? VType, string key)
        {
            try
            {
                var result = await repository.GetTransaction(BranchId, _FD, _TD, VType, key);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
        [HttpGet]
        [Route("InvoiceWiseSales")]
        public async Task<ActionResult<List<dtInvoiceWiseSales>>> GetInvoiceWiseSales(int BranchId, DateTime _FD, DateTime _TD,string? VType, string key)
        {
            try
            {
                var result = await repository.GetInvoiceWiseSales(BranchId, _FD, _TD, VType, key);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }[HttpGet]
        [Route("MonthWiseSales")]
        public async Task<ActionResult<List<dtTransaction>>> GetMonthWiseSales(int BranchId,string? VType,int year, string key)
        {
            try
            {
                var result = await repository.GetMonthWiseSales(BranchId, VType,year, key);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }[HttpGet]
        [Route("DateWiseSales")]
        public async Task<ActionResult<List<dtSalesAnalysis>>> GetSalesDateWIse(int BranchId, DateTime _FD, DateTime _TD,string? VType, string key)
        {
            try
            {
                var result = await repository.GetSalesDateWIse(BranchId, _FD, _TD, VType, key);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
        [HttpGet]
        [Route("GetDataByID")]
        public async Task<ActionResult<IEnumerable<dtFinancialRegister>>> GetDataByID(int BranchId, int VId, string key)
        {
            DateTime _FDate, _TDate;
            var AcctStmt = new List<dtFinancialRegister>();
            try
            {
                AcctStmt = await repository.GetDataByID(BranchId, VId, key);
            }
            catch (Exception ex)
            { }
            return AcctStmt;


        }  
        [HttpGet]
        [Route("GetVoucherEntry")]
        public async Task<ActionResult<IEnumerable<dtFinancialRegister>>> GetVoucherEntry(long VId, int BranchId, string key)
        {
            DateTime _FDate, _TDate;
            var AcctStmt = new List<dtFinancialRegister>();
            try
            {
                AcctStmt = await repository.GetVoucherEntry(BranchId, VId, key);
            }
            catch (Exception ex)
            { }
            return AcctStmt;


        } 
        [HttpGet]
        [Route("GetVType")]
        public async Task<ActionResult<IList<string>>> GetVType(int BranchId, string key)
        {
            var vType = new List<string>();
            try
            {
                vType = await repository.GetVType(BranchId, key);
            }
            catch (Exception ex)
            { }
            return vType;


        }
    }
}
