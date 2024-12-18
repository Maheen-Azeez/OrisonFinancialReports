using OrisonMIS.Shared.Entities.Inventory;
using OrisonMIS.Shared.Entities.Inventory.BoldReport;

namespace OrisonMIS.Client.Logics.Contract.Inventory.BoldReport
{
    public interface IReportViewerManager
    {
        public Task<PurchaseOrder> GetPurchaseOrder(string VoucherID, string BranchID);
        public Task<List<Company>> GetCompany(string VoucherID, string BranchID);
        public Task<List<Transaction>> GetTransaction(string VoucherID, string BranchID);
        public Task<List<dtInvVoucher>> GetVoucher(string VoucherID, string BranchID);
        public Task<List<dtInvVoucherAdditionals>> GetVoucherAdditionals(string VoucherID, string BranchID);
    }
}
