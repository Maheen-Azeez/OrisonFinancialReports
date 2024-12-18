using Dapper;
using OrisonMIS.Server.Contract.Financial.Main;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Shared.Entities.Financial.Main;
using System.Data;

namespace OrisonMIS.Server.Concrete.Financial.Main
{
    public  class AccountListManager: IAccountList
    {
        private readonly IDapperManager _dapperManager;
        public AccountListManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task<List<AccountList>> Get(string AccList, long BranchId, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("AccList", AccList, DbType.String);
            dbPara.Add("BranchId", BranchId, DbType.Int32);
            dbPara.Add("Criteria", "AccountList", DbType.String);
            //dtInvVoucher voucher = new dtInvVoucher();
            var Accs = Task.FromResult(_dapperManager.GetAll<AccountList>
                                ("[FINWEB_FinancialStmtSP]",key, dbPara, commandType: CommandType.StoredProcedure));
            //($"SELECT * FROM [Article] WHERE Title like '%{search}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
            return await Accs;
        }
    }
}
