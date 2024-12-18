using Dapper;
using OrisonMIS.Server.Contract.Financial.Main;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Shared.Entities.Financial;
using System.Data;

namespace OrisonMIS.Server.Concrete.Financial.Main
{
    public class VoucherAllocationManager:IVoucherAllocation
    {
        private readonly IDapperManager _dapperManager;
        public VoucherAllocationManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public async Task<List<VoucherAllocation>> ShowAllocation(long AccId,  long VID, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("AccountId", AccId, DbType.Int32);
            dbPara.Add("VID", VID, DbType.Int32);
            dbPara.Add("Criteria", "VoucherAllocation", DbType.String);
            //dtInvVoucher voucher = new dtInvVoucher();
            var Bill = Task.FromResult(_dapperManager.GetAll<VoucherAllocation>
                                ("[FINWEB_FinancialStmtSP]", key, dbPara, commandType: CommandType.StoredProcedure));
            //($"SELECT * FROM [Article] WHERE Title like '%{search}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
            return await Bill;
        }
    }
}
