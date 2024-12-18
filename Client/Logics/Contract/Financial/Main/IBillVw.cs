using OrisonMIS.Shared.Entities.Financial;

namespace OrisonMIS.Client.Logics.Contract.Financial.Main
{
    public interface IBillVw
    {
        Task<IEnumerable<BillVw>> ShowBills(long AccId, long BranchId);
    }
}
