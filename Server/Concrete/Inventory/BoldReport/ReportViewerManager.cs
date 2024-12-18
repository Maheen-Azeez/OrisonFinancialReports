using Dapper;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Server.Contract.Inventory.BoldReport;
using OrisonMIS.Shared.Entities.Inventory;
using OrisonMIS.Shared.Entities.Inventory.BoldReport;
using System.Data;

namespace OrisonMIS.Server.Concrete.Inventory.BoldReport
{
    public class ReportViewerManager : IReportViewerManager
    {
        private readonly IDapperManager _dapperManager;
        private readonly IConfiguration _config;
        public ReportViewerManager(IDapperManager dapperManager, IConfiguration config)
        {
            _dapperManager = dapperManager;
            _config = config;
        }
        public async Task<List<Company>> GetCompany(string VoucherID, string BranchID, string Criteria, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("VoucherID", VoucherID, DbType.Int32);
            dbPara.Add("BranchId", BranchID, DbType.Int32);
            dbPara.Add("Criteria", Criteria, DbType.String);

            var Company = Task.FromResult(_dapperManager.GetAll<Company>
                                ("[dbo].[FinWeb_PurchaseOrderPrint]", key, dbPara, commandType: CommandType.StoredProcedure));
            return await Company;
        }
        public async Task<List<Transaction>> GetTransaction(string VoucherID, string BranchID, string Criteria, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("VoucherID", VoucherID, DbType.Int32);
            dbPara.Add("BranchId", BranchID, DbType.Int32);
            dbPara.Add("Criteria", Criteria, DbType.String);

            var Transaction = Task.FromResult(_dapperManager.GetAll<Transaction>
                                ("[dbo].[FinWeb_PurchaseOrderPrint]", key, dbPara, commandType: CommandType.StoredProcedure));
            return await Transaction;
        }
        public async Task<List<PurchaseDetails>> GetPurchaseDetails(string VoucherID, string BranchID, string Criteria, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("VoucherID", VoucherID, DbType.Int32);
            dbPara.Add("BranchId", BranchID, DbType.Int32);
            dbPara.Add("Criteria", Criteria, DbType.String);

            var PurchaseDetails = Task.FromResult(_dapperManager.GetAll<PurchaseDetails>
                                ("[dbo].[FinWeb_PurchaseOrderPrint]", key, dbPara, commandType: CommandType.StoredProcedure));
            return await PurchaseDetails;
        }
        public async Task<List<dtInvVoucher>> GetVoucher(long VId, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("VId", VId, DbType.Int32);
            dbPara.Add("Criteria", "Voucher", DbType.String);
            //dtInvVoucher voucher = new dtInvVoucher();
            var voucher = Task.FromResult(_dapperManager.GetAll<dtInvVoucher>
                                ("[FINWEB_INVENTORYVoucherSP]", key, dbPara,
                                commandType: CommandType.StoredProcedure));
            //($"SELECT * FROM [Article] WHERE Title like '%{search}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
            return await voucher;
        }
        public async Task<List<dtInvVoucherAdditionals>> GetVoucherAdditionals(long VId, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("VId", VId, DbType.Int32);
            dbPara.Add("Criteria", "VoucherAdditionals", DbType.String);
            //dtInvVoucher voucher = new dtInvVoucher();
            var voucherAdditionals = Task.FromResult(_dapperManager.GetAll<dtInvVoucherAdditionals>
                                ("[FINWEB_INVENTORYVoucherSP]",key, dbPara, commandType: CommandType.StoredProcedure));
            //($"SELECT * FROM [Article] WHERE Title like '%{search}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
            return await voucherAdditionals;
        }
    }
}
