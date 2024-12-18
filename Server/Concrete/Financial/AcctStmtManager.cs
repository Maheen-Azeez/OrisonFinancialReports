using Dapper;
using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.AspNetCore.Mvc;
using OrisonMIS.Server.Concrete.Financial.Main;
using OrisonMIS.Server.Contract.Financial;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Shared.Entities.Financial;
using OrisonMIS.Shared.Entities.General;
using System.Data;
using System.Reflection;
using StatementType = OrisonMIS.Shared.Entities.Financial.StatementType;

namespace OrisonMIS.Server.Concrete.Financial
{
    public class AcctStmtManager : IAccStmt

    {
        private readonly IDapperManager _dapperManager;
        private readonly IDBOperation _DB;
        private readonly IUserRightsManager userRightsManager;
        public AcctStmtManager(IDapperManager dapperManager, IDBOperation DB, IUserRightsManager userRightsManager)
        {
            _dapperManager = dapperManager;
            _DB = DB;
            this.userRightsManager = userRightsManager;
        }
        public async Task<List<AcctStmt>> Show(long BranchId, DateTime DateFrom, DateTime DateTo, object AccountID, string key)
        {
            try
            {
                //string school = _DB.IsSchool(key);
                var dbPara = new DynamicParameters();
                string ProcName;
                ProcName = "FinRep_AccountStmtSP";
                dbPara.Add("BranchId", BranchId, DbType.Int32);
                dbPara.Add("DateFrom", DateFrom, DbType.DateTime);
                dbPara.Add("DateUpto", DateTo, DbType.DateTime);
                dbPara.Add("AccountID", AccountID, DbType.Int32);
                dbPara.Add("AllBranch", BranchId == 0 ? 1 : 0, DbType.Int32);
                var AcctStmt = Task.FromResult(_dapperManager.GetAll<AcctStmt>
                                    (ProcName, key, dbPara, commandType: CommandType.StoredProcedure));
                return await AcctStmt;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public async Task<List<AcctStmt>> Show(long branchId, DateTime dateFrom, DateTime dateTo, object accountID,StatementType statementType, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("BranchId", branchId, DbType.Int32);
            dbPara.Add("DateFrom", dateFrom, DbType.DateTime);
            dbPara.Add("DateUpto", dateTo, DbType.DateTime);
            dbPara.Add("AccountID", accountID, DbType.Int32);

            IAccountStatement stmt = AccountStatementFactory.GetAccountStatementInstance(statementType);
            var statement = stmt.GetAccountStatement(key, dbPara, _dapperManager);

            return await statement;
        }
        
        public async Task<List<BankDetails>> ShowBank(long BranchId, string key)
        {
            var dbPara = new DynamicParameters();
            string ProcName;

            ProcName = "FinRep_BankDetailsSP";
            dbPara.Add("BranchId", BranchId, DbType.Int32);
            var AcctStmt = Task.FromResult(_dapperManager.GetAll<BankDetails>
                               (ProcName,key, dbPara, commandType: CommandType.StoredProcedure));
            return await AcctStmt;
        }
        public async Task<List<BankDetails>> ShowYearwise(string AccCategory, long BranchId, string key)
        {
            var dbPara = new DynamicParameters();
            string ProcName;

            ProcName = "CreditAccountWiseSP";
            dbPara.Add("AccCategory", AccCategory, DbType.String);
            dbPara.Add("BranchId", BranchId, DbType.Int32);
            var AcctStmt = Task.FromResult(_dapperManager.GetAll<BankDetails>
                               (ProcName, key, dbPara, commandType: CommandType.StoredProcedure));
            return await AcctStmt;
        }
        public async Task<List<MonthlyProfit>> ShowProfit(long BranchId, DateTime DateFrom, DateTime DateTo, string key)
        {

            var dbPara = new DynamicParameters();
            string ProcName;

            ProcName = "FinRep_MonthlyProfitSP";
            dbPara.Add("BranchId", BranchId, DbType.Int32);
            dbPara.Add("DateFrom", DateFrom, DbType.DateTime);
            dbPara.Add("DateUpto", DateTo, DbType.DateTime);
            var AcctStmt = Task.FromResult(_dapperManager.GetAll<MonthlyProfit>
                                (ProcName,key, dbPara, commandType: CommandType.StoredProcedure));
            return await AcctStmt;
        }
        public async Task<List<BudgetReg>> ShowBudget(long BranchId, DateTime DateFrom, DateTime DateTo, string finyear, string key)
        {

            var dbPara = new DynamicParameters();
            string ProcName;

            ProcName = "FinRep_BudgetRegisterAllWebSP";
            dbPara.Add("Financialyear", finyear, DbType.String);
            dbPara.Add("BranchId", BranchId, DbType.Int32);
            dbPara.Add("FromDate", DateFrom, DbType.DateTime);
            dbPara.Add("ToDate", DateTo, DbType.DateTime);
            var AcctStmt = Task.FromResult(_dapperManager.GetAll<BudgetReg>
                                (ProcName,key, dbPara, commandType: CommandType.StoredProcedure));
            return await AcctStmt;
        }
        public async Task<List<TrialBal>> ShowTB(long BranchId, DateTime DateFrom, DateTime DateTo, string opening, string key)
        {

            var dbPara = new DynamicParameters();
            string ProcName;

            ProcName = BranchId == 0 ? "TrialBalanceWCSAllBranchesSP" : "TrialBalanceSP";

            //dbPara.Add("AllBranch", BranchId == 0 ? 1 : 0, DbType.Int32);

            dbPara.Add("Opening", opening, DbType.Byte);
            dbPara.Add("BranchId", BranchId, DbType.Int32);
            dbPara.Add("DateFrom", DateFrom, DbType.DateTime);
            dbPara.Add("DateUpto", DateTo, DbType.DateTime);
            var AcctStmt = Task.FromResult(_dapperManager.GetAll<TrialBal>
                                (ProcName,key, dbPara, commandType: CommandType.StoredProcedure));
            return await AcctStmt;
        }
        public async Task<List<TrialBal>> GetTBDetailed(long BranchId, DateTime DateFrom, DateTime DateTo, string opening, string key)
        {

            try
            {
                var dbPara = new DynamicParameters();
                string ProcName;

                ProcName = "TrialBalanceOpSP";

                dbPara.Add("Opening", opening, DbType.Byte);
                dbPara.Add("BranchId", BranchId, DbType.Int32);
                dbPara.Add("DateFrom", DateFrom, DbType.DateTime);
                dbPara.Add("DateUpto", DateTo, DbType.DateTime);
                var AcctStmt = Task.FromResult(_dapperManager.GetAll<TrialBal>
                                    (ProcName, key, dbPara, commandType: CommandType.StoredProcedure));
                return await AcctStmt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<List<PDC>> ShowPDC(long BranchId, string status, string key)
        {
            var dbPara = new DynamicParameters();
            string ProcName;

            ProcName = "FinRep_PDCReportsSP";
            dbPara.Add("BranchID", BranchId, DbType.Int32);
            dbPara.Add("status", status, DbType.String);
            var AcctStmt = Task.FromResult(_dapperManager.GetAll<PDC>
                               (ProcName,key, dbPara, commandType: CommandType.StoredProcedure));
            return await AcctStmt;
        }

        public async Task<ActionResult<List<dtInvAccounts>>> GetStaffAccounts(long branchId, string key)
        {
            var dbPara = new DynamicParameters();
            string query = "SELECT AccountCode,AccountName,ID, AccCategory, Voucherentry,isnull(BranchID,0) BranchID FROM AccountsVW where AccCategory= 'STAFF' UNION SELECT AccountCode,AccountName,ID, AccCategory, Voucherentry,isnull(BranchID,0) BranchID FROM AccountsVW where ID = 54";
            dbPara.Add("BranchID", branchId, DbType.Int32);
            var AcctStmt = Task.FromResult(_dapperManager.GetAll<dtInvAccounts>
                               (query, key, dbPara, commandType: CommandType.Text));
            return await AcctStmt;
        }
        public async Task<ActionResult<List<dtInvAccounts>>> CheckPermissionAndGetStaffAccount(int userId, string keyWord, string module, int branchId, string userCategory, string key)
        {
            List<dtInvAccounts> staffAccounts = new List<dtInvAccounts>();
            var dbPara = new DynamicParameters();
         
            var userRights =  await userRightsManager.GetUserRights(userId, keyWord, module, branchId, key);

            string query = "SELECT AccountCode,AccountName,ID, AccCategory, Voucherentry,isnull(BranchID,0) BranchID FROM AccountsVW where AccCategory= 'STAFF' UNION SELECT AccountCode,AccountName,ID, AccCategory, Voucherentry,isnull(BranchID,0) BranchID FROM AccountsVW where ID = 54";
            dbPara.Add("BranchID", branchId, DbType.Int32);
            
            if (userRights != null && userRights.AllowOpen && userCategory == "Administrator") { 
                staffAccounts = await Task.FromResult(_dapperManager.GetAll<dtInvAccounts>
                               (query, key, dbPara, commandType: CommandType.Text));
            }
            
            return staffAccounts;
        }
    }
}
