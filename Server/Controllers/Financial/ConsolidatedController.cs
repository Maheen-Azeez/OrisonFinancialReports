using System;
using System.Collections.Generic;
using System.Dynamic;
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
    public class ConsolidatedController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private IConsolidated _repository;
        public ConsolidatedController( IWebHostEnvironment environment, IConsolidated repository)
        {
            _environment = environment;
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));

        }
        // GET: api/Consolidated?AccountID=21&BranchId=31&_FD=01-09-2020&_TD=01-08-2021&Group=0&AccYear=2020-2021&SP=Group
        [HttpGet]
        
        public async Task<ActionResult<IEnumerable<Consolidated>>> Get(long AccountID, long BranchId, string _FD, string _TD, int Group, string? AccYear, string SP, string? selectedCriteria, string key)
        {
            var AcctStmt = new List<Consolidated>();
            DateTime _FDate = Convert.ToDateTime(_FD);
            DateTime _TDate = Convert.ToDateTime(_TD);
            try
            {
                AcctStmt = await _repository.Show(BranchId, _FDate, _TDate, AccountID, Group, AccYear, SP,selectedCriteria,key);
                if (AcctStmt == null)
                {
                    AcctStmt = new List<Consolidated>();
                }
            }
            catch (Exception ex)
            { }
            return AcctStmt;


        }
        //[HttpGet]
        //[Route("ConsolidatedBranchWise")]
        //public async Task<ActionResult<IEnumerable<ConsolidatedBranchWise>>> GetConsolidatedBranchWise(long AccountID, long BranchId, string _FD, string _TD, int Group, string? AccYear, string SP, string? selectedCriteria, string key)
        //{
        //    var AcctStmt = new List<ConsolidatedBranchWise>();
        //    DateTime _FDate = Convert.ToDateTime(_FD);
        //    DateTime _TDate = Convert.ToDateTime(_TD);
        //    try
        //    {
        //        AcctStmt = await _repository.GetConsolidatedBranchWise(BranchId, _FDate, _TDate, AccountID, Group, AccYear, SP,selectedCriteria,key);
        //        if (AcctStmt == null)
        //        {
        //            AcctStmt = new List<ConsolidatedBranchWise>();
        //        }
        //    }
        //    catch (Exception ex)
        //    { }
        //    return AcctStmt;


        //}
        [HttpGet]
        [Route("ConsolidatedBranchWise")]
        public async Task<ActionResult<IEnumerable<object>>> GetConsolidatedBranchWise(long AccountID, long BranchId, string _FD, string _TD, int Group, string? AccYear, string SP, string? selectedCriteria, string key)
        {
            var AcctStmt = new List<object>();
            DateTime _FDate = Convert.ToDateTime(_FD);
            DateTime _TDate = Convert.ToDateTime(_TD);
            try
            {
                AcctStmt = await _repository.GetConsolidatedBranchWise(BranchId, _FDate, _TDate, AccountID, Group, AccYear, SP,selectedCriteria,key);
                if (AcctStmt == null)
                {
                    AcctStmt = new List<object>();
                }
            }
            catch (Exception ex)
            { }
            return AcctStmt;


        }
        [HttpGet]
        [Route("Aging")]
        public async Task<ActionResult<IEnumerable<AgingDetail>>> GetAgingDetails(string key)
        {
            return await _repository.GetAgingDetails(key);
        }
    }
}
