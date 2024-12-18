using OrisonMIS.Shared.Entities.Financial;

namespace OrisonMIS.Client.Logics.Contract.Financial.Main
{
    public interface IAccountAllocation
    {
        Task<IEnumerable<VoucherAllocation>> AccountAllocation(long AccId, long VID);
    }
}
