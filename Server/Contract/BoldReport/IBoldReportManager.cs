using Microsoft.AspNetCore.Mvc;
using OrisonMIS.Shared.BoldReport;

namespace OrisonMIS.Server.Contract.BoldReport
{
    public interface IBoldReportManager
    {
        Task<FileStreamResult> GetReport(DataSource Data,string key);

    }
}
