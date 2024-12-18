using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrisonMIS.Server.Contract.Inventory.BoldReport;
using OrisonMIS.Shared.Entities.Inventory;
using OrisonMIS.Shared.Entities.Inventory.BoldReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Server.Controllers.Inventory.BoldReport
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportViewerController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private IReportViewerManager _repository;

        public ReportViewerController( IWebHostEnvironment environment, IReportViewerManager repository)
        {
            _environment = environment;
            _repository = repository;
        }
        // GET: api/ReportViewer?VoucherID=938228&BranchID=49
        [HttpGet]
        public async Task<ActionResult<PurchaseOrder>> Get(string VoucherID, string BranchID, string key)
        {
            var Company = await _repository.GetCompany(VoucherID, BranchID, "Company",key);
            var Transaction = await _repository.GetTransaction(VoucherID, BranchID, "Transactions",key);
            var PurchaseDetails = await _repository.GetPurchaseDetails(VoucherID, BranchID, "PurchaseDetails",key);
            PurchaseOrder Result = new PurchaseOrder
            {
                CompanyDetails = Company,
                TransactionDetails = Transaction,
                OrderDetails = PurchaseDetails
            };
            if (Result == null)
            {
                return NotFound();
            }

            return Result;
        }
        // GET: api/ReportViewer/GetCompany?VoucherID=938228&BranchID=49
        [HttpGet]
        [Route("GetCompany")]
        public async Task<ActionResult<List<Company>>> GetCompany(string VoucherID, string BranchID, string key)
        {
            var Result = await _repository.GetCompany(VoucherID, BranchID, "Company",key);
            if (Result == null)
            {
                return NotFound();
            }
            return Result;
        }
        // GET: api/ReportViewer/GetTransaction?VoucherID=938228&BranchID=49
        [HttpGet]
        [Route("GetTransaction")]
        public async Task<ActionResult<List<Transaction>>> GetTransaction(string VoucherID, string BranchID, string key)
        {
            var Result = await _repository.GetTransaction(VoucherID, BranchID, "Transactions",key);
            if (Result == null)
            {
                return NotFound();
            }
            return Result;
        }
        // GET: api/ReportViewer/GetVoucher?=VoucherID=938228
        [HttpGet]
        [Route("GetVoucher")]
        public async Task<ActionResult<List<dtInvVoucher>>> GetVoucher(string VoucherID, string key)
        {
            var Result = await _repository.GetVoucher(Convert.ToInt32(VoucherID),key);
            if (Result == null)
            {
                return NotFound();
            }
            return Result;
        }
        // GET: api/ReportViewer/GetTransaction?VoucherID=938228
        [HttpGet]
        [Route("GetVoucherAdditionals")]
        public async Task<ActionResult<List<dtInvVoucherAdditionals>>> GetVoucherAdditionals(string VoucherID, string key)
        {
            var Result = await _repository.GetVoucherAdditionals(Convert.ToInt32(VoucherID),key);
            if (Result == null)
            {
                return NotFound();
            }
            return Result;
        }
    }
}
