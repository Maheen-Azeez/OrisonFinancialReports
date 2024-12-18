using Dapper;
using OrisonMIS.Server.Contract.Financial.Main;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Shared.Entities.Financial.Main;
using System.Data;

namespace OrisonMIS.Server.Concrete.Financial.Main
{
    public class ChequeManager : ICheque
    {
        private readonly IDapperManager _dapperManager;
        public ChequeManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public async Task<List<Cheque>> ShowCheque(long VId, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("VID", VId, DbType.Int32);
            dbPara.Add("Criteria", "Cheques", DbType.String);
            //dtInvVoucher voucher = new dtInvVoucher();
            var Bill = Task.FromResult(_dapperManager.GetAll<Cheque>
                                ("[FINWEB_FinancialStmtSP]", key, dbPara, commandType: CommandType.StoredProcedure));
            //($"SELECT * FROM [Article] WHERE Title like '%{search}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
            return await Bill;
        }
    }
}
