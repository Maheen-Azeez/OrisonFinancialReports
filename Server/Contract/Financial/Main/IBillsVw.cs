using OrisonMIS.Shared.Entities.Financial;

namespace OrisonMIS.Server.Contract.Financial.Main
{
    public interface IBillsVw : IDisposable
    {
        Task<List<BillVw>> ShowBills(long AccId, long BranchId, string key);
    }
}
