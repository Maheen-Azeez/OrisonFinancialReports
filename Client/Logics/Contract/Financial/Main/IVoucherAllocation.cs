using OrisonMIS.Shared.Entities.Financial;

namespace OrisonMIS.Client.Logics.Contract.Financial.Main
{
    public interface IVoucherAllocation
    {
        Task<IEnumerable<VoucherAllocation>> ShowAllocation(long AccId, long VID);
    }
}
