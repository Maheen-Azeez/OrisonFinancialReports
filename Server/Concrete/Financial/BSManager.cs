using Dapper;
using OrisonMIS.Server.Contract.Financial;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Shared.Entities.Financial;
using System.Data;

namespace OrisonMIS.Server.Concrete.Financial
{
    public class BSManager:IBS

    {
        private readonly IDapperManager _dapperManager;
        public BSManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }
        public void Dispose()
        {
            //throw new NotImplementedException();
        }
        public async Task<List<BalanceSheet>> Show( long BranchId, DateTime DateFrom, DateTime DateTo, string SP, string key)
        {

            var dbPara = new DynamicParameters();
            string ProcName;


            if (SP == "BS")
            {
                //ProcName = "[BalanceSheetSP]";
                ProcName = BranchId == 0 ? "FinRep_BalanceSheetWCSAllBranchesSP" : "FinRep_BalanceSheetSP";
                dbPara.Add("BranchId", BranchId, DbType.Int32);
                dbPara.Add("DateFrom", DateFrom, DbType.DateTime);
                dbPara.Add("DateUpto", DateTo, DbType.DateTime);
            }
            else 
            {
                //ProcName = "BalanceSheetWCSSPWithHistory";
                //dbPara.Add("finyear", Finyear, DbType.Object);
                ProcName = BranchId == 0 ? "FinRep_BalanceSheetWCSAllBranchesSP" : "BalanceSheetWCSSPWithHistory";
                dbPara.Add("BranchId", BranchId, DbType.Int32);
                dbPara.Add("DateFrom", DateFrom, DbType.DateTime);
                dbPara.Add("DateUpto", DateTo, DbType.DateTime);
            }


            var AcctStmt = Task.FromResult(_dapperManager.GetAll<BalanceSheet>
                                (ProcName, key, dbPara, commandType: CommandType.StoredProcedure));
            //($"SELECT * FROM [Article] WHERE Title like '%{search}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
            return await AcctStmt;
        }
 
    }
}
