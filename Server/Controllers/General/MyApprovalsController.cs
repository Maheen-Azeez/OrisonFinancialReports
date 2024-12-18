using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Server.Contract.Inventory;
using OrisonMIS.Shared.Entities.Inventory;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Server.Controllers.General
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyApprovalsController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private IMyApprovalsManager _repository;
        private IInvVoucherStatusManager _vs;

        public MyApprovalsController( IWebHostEnvironment environment, IMyApprovalsManager repository, IInvVoucherStatusManager vs)
        {
            _environment = environment;
            _repository = repository;
            _vs = vs;
        }
        // GET: api/MyApprovals?ID=130469&BranchId=31
        [HttpGet]
        public async Task<ActionResult<IEnumerable<dtInvVoucherStatus>>> MyApprovals(int ID, int BranchID, string key)
        {
            List<dtInvVoucherStatus> MyApprovals = (List<dtInvVoucherStatus>)await _repository.MyApprovals(ID, BranchID,key);

            if (MyApprovals == null)
            {
                return NotFound();
            }

            return MyApprovals;
        }
        //[HttpGet("{BranchID}/{key}")]
        [HttpGet]
        [Route("Approvals")]

        public async Task<ActionResult<IEnumerable<dtInvVoucherStatus>>> Approvals( int BranchID, string key)
        {
            List<dtInvVoucherStatus> MyApprovals = (List<dtInvVoucherStatus>)await _repository.Approvals( BranchID,key);

            if (MyApprovals == null)
            {
                return NotFound();
            }

            return MyApprovals;
        }
        // GET: api/MyApprovalsStatus?ID=130469&VID=938135&BranchId=31
        //[HttpGet("{ID}/{VID}/{BranchID}/{key}")]
        [HttpGet]
        [Route("MyApprovalsStatus")]
        public async Task<ActionResult<IEnumerable<dtInvVoucherStatus>>> MyApprovalsStatus(int ID,long VID, int BranchID, string key)
        {
            List<dtInvVoucherStatus> MyApprovalsStatus = (List<dtInvVoucherStatus>)await _repository.MyApprovalsStatus(ID,VID, BranchID,key);

            if (MyApprovalsStatus == null)
            {
                return NotFound();
            }

            return MyApprovalsStatus;
        }
        public async Task<int> Approved(dtInvVoucherStatus vs, string key)
        {
            int id = 0;
            try
            {
                if (vs.Remarks == "NA")
                    id = await _vs.NextApprover(vs.VID, vs.SubStatus, vs.Status, vs.UserID, vs.ApproverID, vs.BranchID, vs.Keyword,key);
                else
                    id = await _vs.Approved(vs.VID, vs.SubStatus, vs.Status, vs.UserID, vs.ApproverID, vs.Remarks,vs.Keyword,key);
            }
            catch (Exception ex)
            {
            }
            
            return id;
        }
        //[HttpGet("{VID}/{SubStatus}/{Status}/{UserID}/{ApproverID}/{BranchID}/{Keyword}/{key}")]
        [HttpGet]
        [Route("NextApprover")]
        public async Task<int> NextApprover(int VID, string SubStatus,string Status,int UserID,string ApproverID,string BranchID,string Keyword, string key)
        {
            int id = 0;
            try
            {
                    id = await _vs.NextApprover(VID, SubStatus, Status, UserID, ApproverID, BranchID, Keyword,key);
               
            }
            catch (Exception ex)
            {
            }

            return id;
        }

    }
}
 