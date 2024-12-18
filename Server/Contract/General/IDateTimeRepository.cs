using OrisonMIS.Shared.Entities.General;

namespace OrisonMIS.Server.Contract.General
{
    public interface IDateTimeRepository
    {
        Task<DateTime> GetEntryFromDateTimeAsync(int branchId, string key);
        Task<FinancialDateTime> GetFinancialDateTimeAsync(int branchId, string key);
        Task<DateTime> GetVatDateTimeAsync(int branchId, string key);
    }
}
