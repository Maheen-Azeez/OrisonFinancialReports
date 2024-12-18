using OrisonMIS.Shared.Entities.Financial;

namespace OrisonMIS.Server.Contract.Financial.Main
{
    public interface IVoucherAllocation : IDisposable
    {
        Task<List<VoucherAllocation>> ShowAllocation(long AccId, long VID, string key);
    }
}
