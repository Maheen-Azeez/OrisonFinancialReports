using OrisonMIS.Shared.Entities.Financial;

namespace OrisonMIS.Server.Contract.Financial
{
    public interface IPnL:IDisposable
    {
        Task<List<PnL>> Show(long BranchId, DateTime DateFrom, DateTime DateTo, object Double, string SP, string key);
    }
}
