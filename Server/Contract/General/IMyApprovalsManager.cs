using OrisonMIS.Shared.Entities.Inventory;

namespace OrisonMIS.Server.Contract.General
{
    public interface IMyApprovalsManager
    {
        public Task<IList<dtInvVoucherStatus>> MyApprovals(int ID, int BranchID, string key);
        public Task<IList<dtInvVoucherStatus>> Approvals(int BranchID, string key);
        public Task<IList<dtInvVoucherStatus>> MyApprovalsStatus(int ID, long VID, int BranchID, string key);
    }
}
