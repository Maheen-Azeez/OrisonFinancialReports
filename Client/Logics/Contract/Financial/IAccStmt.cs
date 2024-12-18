using OrisonMIS.Shared.Entities.Financial;
using OrisonMIS.Shared.Entities.General;
using System.Collections.ObjectModel;

namespace OrisonMIS.Client.Logics.Contract.Financial
{
    public interface IAccStmt
    {

        Task<ObservableCollection<AcctStmt>> ShowStatementDetails(long BranchId, string DateFrom, string DateTo, int AccountID);
        Task<List<dtInvAccounts>> GetStaffAccounts(int branchId);
        Task<List<dtInvAccounts>> CheckPermissionAndGetStaffAccount(int userId, string keyWord, string module,int branchId, string userCategory);

        Task<HttpResponseMessage> Show(long BranchId, string DateFrom, string DateTo, object AccountID,StatementType statementType);
        Task<IEnumerable<BankDetails>> ShowBank(long BranchId);
        Task<IEnumerable<BankDetails>> ShowYearwise(string AccCategory, long BranchId);
        Task<IEnumerable<MonthlyProfit>> ShowProfit(long BranchId, string DateFrom, string DateTo);
        Task<IEnumerable<BudgetReg>> ShowBudget(long BranchId, string DateFrom, string DateTo, string finyear);
        Task<ObservableCollection<TrialBal>> ShowTB(long BranchId, string DateFrom, string DateTo, string opening);
        Task<ObservableCollection<TrialBal>> ShowTBDetailed(long BranchId, string DateFrom, string DateTo, string opening);
        Task<IEnumerable<PDC>> ShowPDC(long BranchId, string status);
    }
}
