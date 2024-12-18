using OrisonMIS.Shared.Entities.VAT;

namespace OrisonMIS.Client.Logics.Contract.VAT
{
    public interface IVatManager
    {
        Task<VatReportsDto> GetReports(string dateFrom, string dateTo, int branchId);
    }
}
