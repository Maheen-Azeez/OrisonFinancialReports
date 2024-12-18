using OrisonMIS.Shared.Entities.Financial;

namespace OrisonMIS.Server.Contract.Financial.Main
{
    public interface IAccountAllocationManager : IDisposable
    {
        Task<List<VoucherAllocation>> AccountAllocation(long AccId, long VID, string key);
    }
}
