using OrisonMIS.Shared.Entities.Financial;

namespace OrisonMIS.Server.Contract.Financial
{
    public interface IBS:IDisposable
    {
        Task<List<BalanceSheet>> Show(long BranchId, DateTime DateFrom, DateTime DateTo,  string SP, string key);
    }
}
