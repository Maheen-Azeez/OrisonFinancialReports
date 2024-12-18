using OrisonMIS.Shared.BoldReport;
namespace OrisonMIS.Client.Logics.Contract.BoldReport
{
    public interface IBoldReportManager
    {
        public Task<MemoryStream> GetReport(DataSource Value);
    }
}
