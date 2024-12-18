using Dapper;
using OrisonMIS.Server.Contract.Financial.Main;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Shared.Entities.Financial;
using System.Data;

namespace OrisonMIS.Server.Concrete.Financial.Main
{
    public class VEntryManager : IVEntry
    {
        private readonly IDapperManager _dapperManager;
        public VEntryManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }
        public void Dispose()
        {
            //throw new NotImplementedException();
        }


        public async Task<List<VEntry>> Show(long VID, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("VID", VID, DbType.Int32);
            dbPara.Add("Criteria", "VoucherEntry", DbType.String);
            //dtInvVoucher voucher = new dtInvVoucher();
            var VEntry = Task.FromResult(_dapperManager.GetAll<VEntry>
                                ("[FINWEB_FinancialStmtSP]",key, dbPara, commandType: CommandType.StoredProcedure));
            //($"SELECT * FROM [Article] WHERE Title like '%{search}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
            return await VEntry;
        }
    }
}
