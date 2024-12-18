using Dapper;
using Microsoft.Identity.Client;
using OrisonMIS.Server.Contract.Financial;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Shared.Entities.Financial;
using OrisonMIS.Shared.Entities.General;
using System.Data;

namespace OrisonMIS.Server.Concrete.Financial
{
    public class ConsolidatedManager : IConsolidated

    {
        private readonly IDapperManager _dapperManager;
        private readonly IDBOperation _dBOperation;
        public ConsolidatedManager(IDapperManager dapperManager,IDBOperation dBOperation)
        {
            this._dapperManager = dapperManager;
            this._dBOperation = dBOperation;
        }
        public void Dispose()
        {
            //throw new NotImplementedException();
        }
        public async Task<List<Consolidated>> Show(long BranchId, DateTime DateFrom, DateTime DateTo, object AccountID,object Group, string AccYear, string SP, string selectedCriteria, string key)
        {


            var dbPara = new DynamicParameters();

            string ProcName;
            SP = (SP == "Group") && (selectedCriteria == "AllBranch" || BranchId == 0) ? "GroupSummarySP" : SP;
            SP = (SP == "CM") && (BranchId == 0) ? "CMSchool" : SP;
            if((selectedCriteria != "Branch" && selectedCriteria != null) || BranchId == 0)
                dbPara.Add("AllBranch", 1 , DbType.Int32);

            if (selectedCriteria == "BranchDetailed")
            {
                ProcName = "FinRep_GroupSummaryBranchwiseSP";
                dbPara.Add("BranchId", BranchId, DbType.Int32);
                dbPara.Add("DateFrom", DateFrom, DbType.DateTime);
                dbPara.Add("DateUpto", DateTo, DbType.DateTime);
                dbPara.Add("AccountID", AccountID, DbType.Int32);
                dbPara.Add("criteria", "allBranch", DbType.String);
            }
            else if (SP == "CA")
            {
                ProcName = "FinRep_ConsolidatedAgingSPWeb";
                dbPara.Add("BranchId", BranchId, DbType.Int32);
                dbPara.Add("DateFrom", DateFrom, DbType.DateTime);
                dbPara.Add("DateUpto", DateTo, DbType.DateTime);
                dbPara.Add("AccountID", AccountID, DbType.Int32);
            }
            else if (SP == "CASchool")
            {
                ProcName = "FinRep_ConsolidatedAgingSPSchoolWeb";
                dbPara.Add("BranchId", BranchId, DbType.Int32);
                dbPara.Add("DateFrom", DateFrom, DbType.DateTime);
                dbPara.Add("DateUpto", DateTo, DbType.DateTime);
                dbPara.Add("AcademicYear", AccYear, DbType.String);
                dbPara.Add("AccountID", AccountID, DbType.Int32);
            }
            else if (SP=="CM")
            {
                ProcName = "FinRep_ConsolidatedMonthwiseSP1Web";
                dbPara.Add("BranchId", BranchId, DbType.Int32);
                dbPara.Add("DateFrom", DateFrom, DbType.DateTime);
                dbPara.Add("DateUpto", DateTo, DbType.DateTime);
                dbPara.Add("AccountID", AccountID, DbType.Int32);
            }
            else if(SP=="CMSchool")
            {
                ProcName = "FinRep_ConsolidatedMonthwiseSP1SCHOOLWeb";
                dbPara.Add("BranchId", BranchId, DbType.Int32);
                dbPara.Add("DateFrom", DateFrom, DbType.DateTime);
                dbPara.Add("DateUpto", DateTo, DbType.DateTime);
                dbPara.Add("AcademicYear", AccYear, DbType.String);
                dbPara.Add("AccountID", AccountID, DbType.Int32);
            }
            else
            {
                ProcName = "FinRep_GroupSummarySP";
                dbPara.Add("BranchId", BranchId, DbType.Int32);
                dbPara.Add("DateFrom", DateFrom, DbType.DateTime);
                dbPara.Add("DateUpto", DateTo, DbType.DateTime);
                dbPara.Add("AccountID", AccountID, DbType.Int32);
                dbPara.Add("AllGroup", Group, DbType.Byte);
            }
            var AcctStmt = Task.FromResult(_dapperManager.GetAll<Consolidated>
                                (ProcName,key, dbPara, commandType: CommandType.StoredProcedure));
            return await AcctStmt;
        }

        public async Task<List<AgingDetail>> GetAgingDetails(string key)
        {
            var dbPara = new DynamicParameters();
            var yr = Task.FromResult(_dapperManager.GetAll<AgingDetail>($"select * from agingdetails",key, dbPara, commandType: CommandType.Text));
            return await yr;
        }

        //public async Task<List<ConsolidatedBranchWise>> GetConsolidatedBranchWise(long branchId, DateTime fDate, DateTime tDate, long accountID, int group, string? accYear, string sP, string? selectedCriteria, string key)
        //{
        //    try
        //    {
        //        var dbPara = new DynamicParameters();
        //        string ProcName;
        //        ProcName = "GroupSummaryBranchwiseSP";
        //        dbPara.Add("BranchId", branchId, DbType.Int32);
        //        dbPara.Add("DateFrom", fDate, DbType.DateTime);
        //        dbPara.Add("DateUpto", tDate, DbType.DateTime);
        //        dbPara.Add("AccountID", accountID, DbType.Int32);
        //        dbPara.Add("criteria", "branchWise", DbType.String);
        //        var AcctStmt = Task.FromResult(_dapperManager.GetAll<ConsolidatedBranchWise>
        //                            (ProcName, key, dbPara, commandType: CommandType.StoredProcedure));
        //        return await AcctStmt;
        //    }
        //    catch (Exception e)
        //    {

        //        throw e;
        //    }
        //}
        public async Task<List<object>> GetConsolidatedBranchWise(long branchId, DateTime fDate, DateTime tDate, long accountID, int group, string? accYear, string sP, string? selectedCriteria, string key)
        {
            try
            {
                var dbPara = new DynamicParameters();
                string ProcName;
                ProcName = "FinRep_GroupSummaryBranchwiseSP";
                dbPara.Add("BranchId", branchId, DbType.Int32);
                dbPara.Add("DateFrom", fDate, DbType.DateTime);
                dbPara.Add("DateUpto", tDate, DbType.DateTime);
                dbPara.Add("AccountID", accountID, DbType.Int32);
                dbPara.Add("criteria", "branchWise", DbType.String);
                var AcctStmt = Task.FromResult(_dapperManager.GetAll<object>
                                    (ProcName, key, dbPara, commandType: CommandType.StoredProcedure));
                return await AcctStmt;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
