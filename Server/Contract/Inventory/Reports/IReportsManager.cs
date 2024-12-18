namespace OrisonMIS.Server.Contract.Inventory.Reports
{
    public interface IReportsManager : IDisposable
    {
        Task<List<object>> DailyReport(int userid, DateTime FDate, DateTime TDate, string key);

        Task<List<object>> DailyReportDetailed(int userid, DateTime FDate, DateTime TDate, string Crt, string key);

    }
}
