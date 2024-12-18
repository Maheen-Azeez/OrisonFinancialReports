using Dapper;
using OrisonMIS.Server.Contract.Financial.Main;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Shared.Entities.Financial;
using System.Data;

namespace OrisonMIS.Server.Concrete.Financial.Main
{
    public class AccountAllocationManager : IAccountAllocationManager
    {
        private readonly IDapperManager _dapperManager;

        public AccountAllocationManager(IDapperManager dapperManager)
        {
            _dapperManager = dapperManager;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public async Task<List<VoucherAllocation>> AccountAllocation(long AccId, long VID, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("AccountId", AccId, DbType.Int32);
            dbPara.Add("VID", VID, DbType.Int32);
            dbPara.Add("BranchId", 31);
            dbPara.Add("Criteria", "AccountAllocation", DbType.String);
            var Bill = Task.FromResult(_dapperManager.GetAll<VoucherAllocation>
                                ("[FINWEB_FinancialStmtSP]",key, dbPara, commandType: CommandType.StoredProcedure));
            return await Bill;
        }
    }
}
