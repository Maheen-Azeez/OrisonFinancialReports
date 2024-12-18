using Dapper;
using OrisonMIS.Server.Contract.Financial;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Shared.Entities.Financial;
using System.Data;

namespace OrisonMIS.Server.Concrete.Financial
{
    public class CashFlowManager:ICashFlow
    {
        private readonly IDapperManager _dapperManager;
        private readonly IDBOperation _dBOperation;
        public CashFlowManager(IDapperManager dapperManager, IDBOperation dBOperation)
        {
            this._dapperManager = dapperManager;
            this._dBOperation = dBOperation;
        }
        public void Dispose()
        {
            //throw new NotImplementedException();
        }
        public async Task<List<CashFlow>> Show(long BranchId, DateTime DateFrom, DateTime DateTo, string key)
        {


            var dbPara = new DynamicParameters();
            string ProcName;
           
                ProcName = "FinRep_MISReports";
                dbPara.Add("BranchId", BranchId, DbType.Int32);
                dbPara.Add("FromDate", DateFrom, DbType.DateTime);
                dbPara.Add("ToDate", DateTo, DbType.DateTime);
                dbPara.Add("Criteria", "CASHFLOW", DbType.String);


            var AcctStmt = Task.FromResult(_dapperManager.GetAll<CashFlow>
                                (ProcName, key, dbPara, commandType: CommandType.StoredProcedure));
            return await AcctStmt;
        }
    }
}
