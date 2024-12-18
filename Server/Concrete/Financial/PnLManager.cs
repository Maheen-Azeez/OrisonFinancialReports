using Dapper;
using OrisonMIS.Server.Contract.Financial;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Shared.Entities.Financial;
using System.Data;

namespace OrisonMIS.Server.Concrete.Financial
{
    public class PnLManager:IPnL

    {
        private readonly IDapperManager _dapperManager;
        private readonly IDBOperation _dBOperation;
        public PnLManager(IDapperManager dapperManager,IDBOperation dBOperation)
        {
            this._dapperManager = dapperManager;
            this._dBOperation = dBOperation;
        }
        public void Dispose()
        {
            //throw new NotImplementedException();
        }
        public async Task<List<PnL>> Show(long BranchId, DateTime DateFrom, DateTime DateTo, object Double, string SP, string key)
        {

            var dbPara = new DynamicParameters();
            string ProcName;


            if (SP == "PnL")
            {
                ProcName = BranchId == 0 ? "FinRep_ProfitandLossWCSAllBranchesSP" : "FinRep_ProfitandLossSP";
                dbPara.Add("BranchId", BranchId, DbType.Int32);
                dbPara.Add("DateFrom", DateFrom, DbType.DateTime);
                dbPara.Add("DateUpto", DateTo, DbType.DateTime);
            }
            else //if (SP == "PnLWCS")
            {
                ProcName = BranchId == 0 ? "FinRep_ProfitandLossWCSAllBranchesSP" : "FinRep_ProfitandLossWCSSP";
                dbPara.Add("BranchId", BranchId, DbType.Int32);
                dbPara.Add("DateFrom", DateFrom, DbType.DateTime);
                dbPara.Add("DateUpto", DateTo, DbType.DateTime);
                dbPara.Add("DoubleSide", Double, DbType.Byte);
            }
            var AcctStmt = Task.FromResult(_dapperManager.GetAll<PnL>
                                (ProcName, key, dbPara, commandType: CommandType.StoredProcedure));
            return await AcctStmt;
        }
    }
}
