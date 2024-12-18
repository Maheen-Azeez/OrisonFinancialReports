using OrisonMIS.Shared.Entities.Inventory.Reports;

namespace OrisonMIS.Client.Logics.Contract.Inventory.Report
{
    public interface IDailyReportManager
    {
        Task<IEnumerable<DailyReport>> DailyReport(int userid, string FDate, string TDate);
        Task<IEnumerable<DailyReport>> DailyReportDetailed(int userid, string FDate, string TDate, string Crt);
    }
}
