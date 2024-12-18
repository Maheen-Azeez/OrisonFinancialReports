using Microsoft.AspNetCore.Mvc;
using OrisonMIS.Shared.Entities.Financial;
using OrisonMIS.Shared.Entities.General;

namespace OrisonMIS.Server.Contract.Financial
{
    public interface IAccStmt
    {
        Task<List<AcctStmt>> Show(long BranchId, DateTime DateFrom, DateTime DateTo, object AccountID, StatementType statementType, string key);
        Task<List<AcctStmt>> Show(long BranchId, DateTime DateFrom, DateTime DateTo, object AccountID, string key);
        Task<List<BankDetails>> ShowBank(long BranchId, string key);
        Task<List<BankDetails>> ShowYearwise(string AccCategory, long BranchId, string key);
        Task<List<MonthlyProfit>> ShowProfit(long BranchId, DateTime DateFrom, DateTime DateTo, string key);
        Task<List<BudgetReg>> ShowBudget(long BranchId, DateTime DateFrom, DateTime DateTo, string finyear, string key);
        Task<List<TrialBal>> ShowTB(long BranchId, DateTime DateFrom, DateTime DateTo, string opening, string key);
        Task<List<TrialBal>> GetTBDetailed(long BranchId, DateTime DateFrom, DateTime DateTo, string opening, string key);
        Task<List<PDC>> ShowPDC(long BranchId, string status, string key);
        Task<ActionResult<List<dtInvAccounts>>> GetStaffAccounts(long branchId, string key);
        Task<ActionResult<List<dtInvAccounts>>> CheckPermissionAndGetStaffAccount(int userId, string keyWord, string module, int branchId, string userCategory, string key);
    }
}
