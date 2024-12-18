using Dapper;
using OrisonMIS.Server.Contract.Financial;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Shared.Entities.Financial;
using System.Data;

namespace OrisonMIS.Server.Concrete.Financial
{
    public class BillWiseStmtManager : IBillWiseStmt
    {
        private readonly IDapperManager _dapperManager;
        public BillWiseStmtManager(IDapperManager dapperManager)
        {
            _dapperManager = dapperManager;
        }
        public void Dispose()
        {
            //throw new NotImplementedException();
        }
        public async Task<List<BillwiseStmt>> Show(long BranchId, DateTime DateFrom, DateTime DateTo, object AccountID, string key)
        {

            var dbPara = new DynamicParameters();
            string ProcName;

            ProcName = "FinRep_BillWiseStmtSP";
            dbPara.Add("BranchId", BranchId, DbType.Int32);
            dbPara.Add("DateFrom", DateFrom, DbType.DateTime);
            dbPara.Add("DateUpto", DateTo, DbType.DateTime);
            dbPara.Add("AccountID", AccountID, DbType.Int32);

            var AcctStmt = Task.FromResult(_dapperManager.GetAll<BillwiseStmt>
                                (ProcName,key, dbPara, commandType: CommandType.StoredProcedure));
            return await AcctStmt;
        }
    }
}
