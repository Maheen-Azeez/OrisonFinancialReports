using OrisonMIS.Shared.Entities.Financial;

namespace OrisonMIS.Server.Contract.Financial
{
    public interface ICashFlow : IDisposable
    {
        Task<List<CashFlow>> Show(long BranchId, DateTime DateFrom, DateTime DateTo, string key);
       
    }
}
