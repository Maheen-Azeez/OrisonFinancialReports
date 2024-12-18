using OrisonMIS.Shared.Entities.DashBoard;

namespace OrisonMIS.Client.Logics.Contract.DashBoard
{
    public interface IAttendanceService
    {
        Task<IEnumerable<AbsentParent>> GetDivision(string id);
        Task<IEnumerable<ChartDataNew>> GetNationality();
        Task<IEnumerable<AbsentParent>> SaveAttendanceTime(string time);
        Task<IEnumerable<AbsentParent>> GetAllDivision();
        Task<IEnumerable<AbsentParent>> GetAcYear();
        Task<List<Branch>> GetBranches();
        Task<IEnumerable<clsLoginInfo>> GetLogo(string branchid);

        Task<IEnumerable<AbsentParent>> GetDashboard(AbsentParent ab);
        Task<List<Revenue>> GetRevenue(AbsentParent ab);
        Task<List<BankBalance>> GetBankBalance(AbsentParent ab);
        Task<List<FundFlow>> GetFundFlow(AbsentParent ab);
        Task<List<clsNetProfit>> GetNetProfit(AbsentParent absentParent);
        Task<List<clsAccBalance>> GetAccReceivable(AbsentParent absentParent);
        Task<List<clsAccBalance>> GetAccPayable(AbsentParent absentParent);

        Task<IEnumerable<AbsentParent>> GetUrl();

    }
}
