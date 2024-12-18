using OrisonMIS.Shared.Entities.Inventory;
using System.Data;

namespace OrisonMIS.Client.Logics.Contract.Inventory
{
    public interface IInvVoucherStatusManager
    {
        public Task<long> InsertApprovals(dtInvVoucherStatus voucherStatus, IDbConnection db, IDbTransaction tran);
        public Task<int> Approved(int vid, string substatus, string status, int userid,string approverid,string remarks, string keyword);
        public Task<int> NextApprover(int vid, string substatus, string status, int userid, string approverid, string branchid,string keyword);
    }
}
