using Dapper;
using OrisonMIS.Server.Contract.Financial.Main;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Shared.Entities.General;
using System.Data;

namespace OrisonMIS.Server.Concrete.Financial.Main
{
    public class ReceiptManager : IReceiptManager
    {
        private readonly IDapperManager _dapperManager;

        public ReceiptManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public async Task<List<dtVoucherMaster>> ReceiptList(int vtype,int userid, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("VType", vtype, DbType.Int32);
            dbPara.Add("BranchId", 31, DbType.Int32);
            dbPara.Add("userId", userid, DbType.Int32);
            dbPara.Add("Criteria", "ReceiptList", DbType.String);
            var receiptmaster = Task.FromResult(_dapperManager.GetAll<dtVoucherMaster>
                                ("[FINWEB_INVENTORYVoucherSP]",key, dbPara,
                                commandType: CommandType.StoredProcedure));
            
            return await receiptmaster;
        }

    }
}
