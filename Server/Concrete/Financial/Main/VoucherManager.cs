using Dapper;
using OrisonMIS.Server.Contract.Financial.Main;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Shared.Entities.Financial.Main;
using System.Data;

namespace OrisonMIS.Server.Concrete.Financial.Main
{
    public class VoucherManager : IVoucher
    {
        private readonly IDapperManager _dapperManager;
        public VoucherManager(IDapperManager dapperManager)
        {
            _dapperManager = dapperManager;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public async Task<Voucher> ShowVoucher(long VId, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("VID", VId, DbType.Int32);
            dbPara.Add("Criteria", "Voucher", DbType.String);
            //dtInvVoucher voucher = new dtInvVoucher();
            var vou = Task.FromResult(_dapperManager.Get<Voucher>
                                ("[FINWEB_FinancialStmtSP]",key, dbPara, commandType: CommandType.StoredProcedure));
            //($"SELECT * FROM [Article] WHERE Title like '%{search}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
            return await vou;
        }


    }
}
