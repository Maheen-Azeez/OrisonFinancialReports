using OrisonMIS.Shared.Entities.Inventory;
using OrisonMIS.Shared.Entities.Inventory.BoldReport;

namespace OrisonMIS.Server.Contract.Inventory.BoldReport
{
    public interface IReportViewerManager
    {
        public Task<List<Company>> GetCompany(string VoucherID, string BranchID, string Criteria, string key);
        public Task<List<Transaction>> GetTransaction(string VoucherID, string BranchID, string Criteria, string key);
        public Task<List<PurchaseDetails>> GetPurchaseDetails(string VoucherID, string BranchID, string Criteria, string key);
        public Task<List<dtInvVoucher>> GetVoucher(long VId, string key);
        public Task<List<dtInvVoucherAdditionals>> GetVoucherAdditionals(long VId, string key);
    }
}
