
using OrisonMIS.Shared.Entities.VAT;

namespace OrisonMIS.Server.Contract.VAT
{
    public interface IVatManager
    {
        Task<VatReportsDto> getVatReports(DateTime dateFrom, DateTime dateTo, int branchid,string key);
    }
}
