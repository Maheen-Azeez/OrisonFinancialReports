using OrisonMIS.Shared.Entities.Inventory;

namespace OrisonMIS.Logics.Contracts.General
{
    public interface IMyApprovalsManager
    {
        public Task<IList<dtInvVoucherStatus>> MyApprovals(int ID,int BranchID);
        public Task<IList<dtInvVoucherStatus>> Approvals( int BranchID);
        public Task<IList<dtInvVoucherStatus>> MyApprovalsStatus(int ID, long VID, int BranchID);
    }
}
