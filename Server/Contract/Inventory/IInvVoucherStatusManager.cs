using OrisonMIS.Shared.Entities.Inventory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Server.Contract.Inventory
{
   public interface IInvVoucherStatusManager:IDisposable
    {
        Task<long> InsertApprovals(dtInvVoucherStatus voucherStatus, IDbConnection db, IDbTransaction tran);
        Task<int> Approved(long vid, string substatus, string status, int userid,string approverid,string remarks, string keyword, string key);
        Task<int> NextApprover(long vid, string substatus, string status, int userid, string approverid, string branchid,string keyword, string key);
    }
}
